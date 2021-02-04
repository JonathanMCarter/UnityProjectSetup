using UnityEditor;
using UnityEngine;

/****************************************************************************************************************************
 * 
 *  --{   Project Setup Helper  }--
 *							  
 *	Project Setup Helper Editor Window
 *      Does everything that the tool is required to. both the window and the making of the folders.
 *			
 *	Please refrain from editing this script as it will cause who knows what to the tool.
 *			
 *  Written by:
 *      Jonathan Carter
 *      E: jonathan@carter.games
 *      W: https://jonathan.carter.games
 *		
 *  Version: 1.0.0
 *	Last Updated: 04/02/2021 (d/m/y)						
 * 
****************************************************************************************************************************/

namespace CarterGames.Tools
{
    public class ProjectSetupHelper : EditorWindow
    {
        private const string path = "Assets";

        /// <summary>
        /// Static | Adds the button to call to run the setup.
        /// </summary>
        [MenuItem("Tools/Setup Project", priority = 1)]
        public static void RunSetupProject()
        {
            CreateFolders();
        }


        public static void CreateFolders()
        {
            AssetDatabase.CreateFolder(path, "Animations");
            AssetDatabase.CreateFolder(path + "/Animations", "Controllers");
            AssetDatabase.CreateFolder(path, "Artwork");
            AssetDatabase.CreateFolder(path, "Audio");
            AssetDatabase.CreateFolder(path, "Fonts");
            AssetDatabase.CreateFolder(path, "Gizmos");
            AssetDatabase.CreateFolder(path, "Pipeline");
            AssetDatabase.CreateFolder(path, "Prefabs");
            AssetDatabase.CreateFolder(path, "Resources");
            AssetDatabase.CreateFolder(path, "Models");
            AssetDatabase.CreateFolder(path, "Materials");
            AssetDatabase.CreateFolder(path + "/Materials", "Textures");
            AssetDatabase.CreateFolder(path + "/Materials", "Physics Materials");
            AssetDatabase.CreateFolder(path, "Scripts");
            AssetDatabase.CreateFolder(path, "Editor");
            AssetDatabase.CreateFolder(path, "Shaders");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Animations/Controllers/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Artwork/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Audio/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Fonts/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Gizmos/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Pipeline/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Prefabs/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Resources/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Models/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Materials/Textures/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Materials/Physics Materials/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Scripts/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Editor/Placeholder.txt");
            AssetDatabase.CreateAsset(new TextAsset(), path + "/Shaders/Placeholder.txt");
            AssetDatabase.SaveAssets();
            AssetDatabase.DeleteAsset(path + "/ProjectSetupHelper.cs");
        }
    }
}
