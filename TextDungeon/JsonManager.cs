using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;


namespace TextDungeon
{
    public class SaveFile
    {
        public string PName { get; set; }
        public string PJob { get; set; }
        public int PLevel { get; set; }
        public int PGold { get; set; }
    }

    internal class JsonManager
    {
        public SaveFile insavefile = new SaveFile(); // 저장을 위한 형식
        public static string path = "SaveDate.json"; // 파일경로
        private static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; //해당 솔루션 파일위치를 찾고
        private static string relativePath = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", "..", "..", path)); // ".."만큼 상위 폴더로 이동해서 Json파일을 찾는다.

        public void testset()
        {
            insavefile.PName = "테스트이름2";
            insavefile.PJob = "테스트직업2";
            insavefile.PLevel = 1;
            insavefile.PGold = 100;
        }

        public void SaveData()
        {
            testset();
            //저장해야할것(플레이어 이름,직업등등을 insavefile에다가 초기화 해주고 나서 이 함수가 실행되어야함) 그것이 위의 testset함수

            //string json = File.ReadAllText(relativePath);            

            string SerializedJsonResult = JsonConvert.SerializeObject(insavefile); //세이브를 json으로 변환시키고
            File.WriteAllText(relativePath, SerializedJsonResult); //기존json파일에 덮어쓰기
            Console.WriteLine(SerializedJsonResult);
        }

        public void LoadData()
        {

            string json = File.ReadAllText(relativePath);//json파일의 위치값string에 있는 파일을 읽어서 가저옴
            var deserializedObject = JsonConvert.DeserializeObject<SaveFile>(json); //saveFile형식으로 변환

            //로드할 때 뭐뭐 가저올지 매개변수로 받아서 바꿔줘야할것같음 팀원과 상의
            //ex) Player.name = deserializedObject.PName;
        }

    }
}
