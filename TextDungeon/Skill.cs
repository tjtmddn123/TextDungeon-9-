using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextDungeon;
using static TextDungeon.Character;

namespace TectDungeon_Skill
{
    public abstract class Skill
    // 모든 스킬을 나타내는 추상 클래스
    {
        public string Name { get; private set; } // 스킬 이름
        public int Damage { get; private set; } // 스킬의 피해
        public int MpCost { get; private set; } // 스킬의 MP(마나) 소모량
        //private set을 통해 외부에서 직접 변경되지 않고 내부에서만 설정


        public Skill(string name, int damage, int mpCost)
        // 스킬 속성 초기화를 위한 생성자
        {
            Name = name;
            Damage = damage;
            MpCost = mpCost;
        }

        public virtual void UseSkill(Character _player, List<Monster> monsters, int SelectMonster)
        {
            if (_player.Mp >= MpCost)
            {
                Console.WriteLine($"{MpCost}의 MP를 소모하여 '{Name}' 시전!");
                _player.Mp -= MpCost;

                // 몬스터에게 피해 입히기
                int damageDealt = Damage;
                monsters[SelectMonster].Hp -= damageDealt;

                Console.WriteLine($"{monsters[SelectMonster].Name}에게 {damageDealt}의 피해를 입혔습니다.");
                Console.WriteLine($"{monsters[SelectMonster].Name}의 남은 체력: {monsters[SelectMonster].Hp}");
            }
        }
    }
        // 스킬 사용 메소드, 파생 클래스에서 구현
        //스킬을 사용할 때의 동작을 나타냄


    public class FireballSkill : Skill
    // 파이어볼 스킬 클래스
    {
        public FireballSkill() : base("파이어볼 : MP 3 소모", 14, 3) { }
        // 파이어볼 스킬의 기본 속성 초기화

        public override void UseSkill(Character _player, List<Monster> monsters, int SelectMonster)
        // 파이어볼 스킬 사용 시의 동작 정의
        {
            base.UseSkill(_player, monsters, SelectMonster);
        }
    }

    public class PowerStrikeSkill : Skill
    // 파워스트라이크 스킬 클래스
    {
        public PowerStrikeSkill() : base("파워스트라이크 : MP 5 소모", 20, 5) { }

        public override void UseSkill(Character _player, List<Monster> monsters, int SelectMonster)
        // 파워스트라이크 스킬 사용 시의 동작 정의
        {
            base.UseSkill(_player, monsters, SelectMonster);
        }
    }

    public class SuperPunchSkill : Skill
    // 짱짱펀치 스킬 클래스
    {
        public SuperPunchSkill() : base("짱짱펀치 : MP 10 소모", 999, 10) { }

        public override void UseSkill(Character _player, List<Monster> monsters, int SelectMonster)
        // 짱짱펀치 스킬 사용 시의 동작 정의
        {
            base.UseSkill(_player, monsters, SelectMonster);
        }
    }
}

