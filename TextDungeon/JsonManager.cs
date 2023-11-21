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
        public string Name { get; set; }
        public string Job { get; set; }
        public int Level { get; set; }
        public int Gold { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; } // MP 변수 추가
        public double CritChance { get; set; }  //치확
        public double CritiDamage { get; set; }  //크댐
        public double Evasion { get; set; } // 회피율 
        public List<Item> Inventory { get; set; }
        public int stageNum { get; set; }
        public int minStage { get; set; }
    }

    internal class JsonManager
    {
        public SaveFile insavefile = new SaveFile(); // 저장을 위한 형식
        public static string path = "SaveDate.json"; // 파일경로
        private static string baseDirectory = AppDomain.CurrentDomain.BaseDirectory; //해당 솔루션 파일위치를 찾고
        private static string relativePath = Path.GetFullPath(Path.Combine(baseDirectory, "..", "..", "..", "..", path)); // ".."만큼 상위 폴더로 이동해서 Json파일을 찾는다.

        public void testset()
        {
            insavefile.Name = "테스트이름2";
            insavefile.Job = "테스트직업2";
            insavefile.Level = 1;
            insavefile.Gold = 100;
        }

        public void SaveData(Character i, List<Item> inven, int stageNum, int minStage)
        {
            testset();
            //저장해야할것(플레이어 이름,직업등등을 insavefile에다가 초기화 해주고 나서 이 함수가 실행되어야함) 그것이 위의 testset함수
            insavefile.Name = i.Name;
            insavefile.Job = i.Job;
            insavefile.Level = i.Level;
            insavefile.Gold = i.Level;
            insavefile.Atk = i.Atk;
            insavefile.Def = i.Def;
            insavefile.Hp = i.Hp;
            insavefile.Mp = i.Mp;
            insavefile.CritChance = i.CritChance;
            insavefile.CritiDamage = i.CritiDamage;
            insavefile.Evasion = i.Evasion;
            insavefile.Inventory = inven;
            insavefile.stageNum = stageNum;
            insavefile.minStage = minStage;


            //string json = File.ReadAllText(relativePath);            

            string SerializedJsonResult = JsonConvert.SerializeObject(insavefile); //세이브를 json으로 변환시키고
            File.WriteAllText(relativePath, SerializedJsonResult); //기존json파일에 덮어쓰기
            Console.WriteLine(SerializedJsonResult);
        }

        public Character LoadCharacterData()
        {

            string json = File.ReadAllText(relativePath);//json파일의 위치값string에 있는 파일을 읽어서 가저옴
            var deserializedObject = JsonConvert.DeserializeObject<SaveFile>(json); //saveFile형식으로 변환


            return new Character(deserializedObject.Name,deserializedObject.Job,deserializedObject.Level, deserializedObject.Atk,
                deserializedObject.Def,deserializedObject.Hp,deserializedObject.Mp,deserializedObject.Gold,
                deserializedObject.CritChance,deserializedObject.CritiDamage,deserializedObject.Evasion);


            //로드할 때 뭐뭐 가저올지 매개변수로 받아서 바꿔줘야할것같음 팀원과 상의
            //ex) Player.name = deserializedObject.PName;
        }

        public void StageLoad(out int  stageNum, out int minstage)
        {
            string json = File.ReadAllText(relativePath);//json파일의 위치값string에 있는 파일을 읽어서 가저옴
            var deserializedObject = JsonConvert.DeserializeObject<SaveFile>(json); //saveFile형식으로 변환

            stageNum = deserializedObject.stageNum;
            minstage = deserializedObject.minStage;
        }

    }
}
