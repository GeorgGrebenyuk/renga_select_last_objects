using Renga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace select_last_objects
{
    public class init_app : Renga.IPlugin
    {
        public static Renga.IApplication renga_app;
        private Renga.SelectionEventSource eventSelection;
        //Data containers
        public static Dictionary<string, List<int>> time2selected_objects;
        private string project_path = null;
        /// <summary>
        /// Для предотвращения включения выбранных объектов в истории выборки по наатию на кнопку
        /// </summary>
        public static bool NeedIncludeSelectingToHistory = true;

        
        public bool Initialize(string pluginFolder)
        {
            renga_app = new Renga.Application();
            //For selection
            Renga.ISelection internal_selection = renga_app.Selection;
            if (internal_selection != null)
            {
                eventSelection = new SelectionEventSource(internal_selection);
                eventSelection.ModelSelectionChanged += SelectionAction;
            }
            
            //Create buttom
            Renga.IUI renga_UI = renga_app.UI;
            Renga.IUIPanelExtension ui_panel = renga_UI.CreateUIPanelExtension();
            Renga.IAction button_get_frame = renga_UI.CreateAction();
            button_get_frame.DisplayName = "Показать последние выделенные объекты";
            button_get_frame.ToolTip = "Выделить в модели выделенные раннее объекты";
            Renga.IImage icon = renga_UI.CreateImage();
            icon.LoadFromFile(pluginFolder + "\\pic.png");
            button_get_frame.Icon = icon;
            ActionEventSource event_for_button = new ActionEventSource(button_get_frame);
            event_for_button.Triggered += (object sender, EventArgs args) =>
            {
                //Run winforms and select user selections
                Events_frame new_frame = new Events_frame();
                System.Windows.Forms.Application.Run(new_frame);
                new_frame.Close();
            };
            //eventActions.Add(event_for_button);
            ui_panel.AddToolButton(button_get_frame);
            renga_UI.AddExtensionToPrimaryPanel(ui_panel);

            return true;
        }
        private void SelectionAction (object sender, EventArgs args)
        {
            if (renga_app.Project == null) return;

            /*
           * Если пользователь по какой-то причине сменил проект, то наше расширение
           * обнулит внутренний счетчик событий выбора (чтобы исключить ситуацию, что
           * операция вызовется для объектов другого проекта
           */
            if (project_path == null)
            {
                project_path = renga_app.Project.FilePath;
                time2selected_objects = new Dictionary<string, List<int>>();
            }
            else
            {
                //Предусмотреть появление диалогового окна с предупреждением или не делать ... 
                if (renga_app.Project.FilePath != project_path) 
                {
                    CleanData();
                    project_path = renga_app.Project.FilePath;
                    time2selected_objects = new Dictionary<string, List<int>>();
                }

            }

            Renga.ISelection internal_selection = renga_app.Selection;
            if (internal_selection.GetSelectedObjects().Length > 0 && NeedIncludeSelectingToHistory == true)
            {
                List<int> current_selection = ((int[])internal_selection.GetSelectedObjects()).ToList();
                //time pattern from http://www.geekzilla.co.uk/View00FF7904-B510-468C-A2C8-F859AA20581F.htm
                string time_now = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss.fff");
                time2selected_objects.Add(time_now, current_selection);
            }

        }

        public static void ShowSelectedObjects (List<int> dict_indexes, int visiable_option)
        {
            List<int> needing_ids = new List<int>();
            int counter_dict = 0;
            foreach (KeyValuePair<string, List<int>> one_time2ids in time2selected_objects)
            {
                if (dict_indexes.Contains(counter_dict))
                {
                    foreach (int one_id in one_time2ids.Value)
                    {
                        needing_ids.Add(one_id);
                    }
                }
                counter_dict++;
            }
            //needing_ids.Distinct();
            //Выделение объектов
            if (visiable_option == 1) renga_app.Selection.SetSelectedObjects(needing_ids.ToArray());
            else if (visiable_option >= 2)
            {
                Renga.IModelView modelView = renga_app.ActiveView as Renga.IModelView;
                if (modelView != null)
                {
                    if (visiable_option == 2) modelView.SetObjectsVisibility(needing_ids.ToArray(), false);
                    else
                    {
                        //скрыть всё кроме них
                        Renga.IModelObjectCollection models_objects = renga_app.Project.Model.GetObjects();
                        List<int> models_objects_ids = ((int[])models_objects.GetIds()).ToList();
                        //List<int> other_objects_id = models_objects_ids.Except(needing_ids.ToArray()).ToList();

                        modelView.SetObjectsVisibility(models_objects_ids.Except(needing_ids.ToArray()).ToArray(), false);
                        models_objects_ids.Clear();
                    }
                }
            }
            needing_ids.Clear();
        }
        public void Stop()
        {
            //Правила хорошего тона -- очищаем пользовательские события
            CleanData();
        }

        private void CleanData()
        {

            //foreach (var eventSource in eventActions)
                //eventSource.Dispose();
            eventSelection.Dispose();

            time2selected_objects.Clear();
        }
        private void OnProjectClose()
        {
            CleanData();
        }

        
    }
}
