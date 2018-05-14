using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace _6.Dialogue_tree
{

    public class DialogueTree
    {

    }
    public class DialogueRoot
    {
        List<DialogueRoot> RootList;
    }

    public class DialogueNode
    {
        string ConversationId;
        string ParticipantName;
        string EmoteType;
        string Side;
        string Line;
        string SpecialtyAnimation;
        string SpecialtyCamerr;
        string Participants;
        string Conversation;
    }

    public class DialogueNodes : DialogueNode
    {
        List<DialogueNodes> NodeList;
        public DialogueNodes()
        {
            NodeList = new List<DialogueNodes>()
            {

            };
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            DialogueNodes node = File.Open("output.xml", FileMode.Open);

        }
    }
}
