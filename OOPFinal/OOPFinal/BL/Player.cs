using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPFinal.Utility;

namespace OOPFinal.BL
{
    public class Player : Character
    {
        private int punchPower;
        private int BigPunchPower;
        private State state;
        private int jumpSpeed = 15;
        private int gravity = 1;
        public Player()
        {

        }
        public Player(string name, PictureBox character, State state, ProgressBar Health, int AttackPower, int Speed, int BackSpeed, int punchPower, int BigPunchPower) : base(name,character,Health,AttackPower,Speed,BackSpeed)
        {
            this.name = name;
            this.character = character;
            this.state = state;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.Speed = Speed;
            this.BackSpeed = BackSpeed;
            this.punchPower = punchPower;
            this.BigPunchPower = BigPunchPower;

        }

        public int GetPunchPower()
        {
            return punchPower;
        }
        public void SetPunchPower(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("PunchPower cannot be negative.");
            }
            punchPower = value;
        }
        public int GetBigPunchPowerValue()
        {
            return BigPunchPower;
        }
        public void SetBigPunchPowerValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("BigPunchPower cannot be negative.");
            }
            BigPunchPower = value;
        }
        public State GetStateValue()
        {
            return state;
        }
        public void SetStateValue(State value)
        {
            state = value;
        }

        public void StartJump()
        {
            if (state != State.Jumping)
            {
                state = State.Jumping;
                jumpSpeed = 15;
                InitialY = character.Location.Y;
            }
        }

        public void HandleJump()
        {
            if (state == State.Jumping)
            {
                character.Location = new Point(character.Location.X, character.Location.Y - jumpSpeed);
                jumpSpeed -= gravity; 

                if (character.Location.Y >= InitialY)
                {
                    state = State.Normal;
                    character.Location = new Point(character.Location.X, InitialY); 
                    jumpSpeed = 0;
                }
            }
        }

        public override void MoveLeft()
        {
            base.MoveLeft();
            character.Image = Assets.PlayerMoveBack;
        }
        public override void MoveRight()
        {
            base.MoveRight();
            character.Image = Assets.PlayerMove;
        }
        public enum State
        {
            Normal,
            MovingForward,
            MovingBackward,
            Firing,
            SmallPunch,
            BigPunch,
            Jumping,
            Defend,
            Died,
            Win
        }

        
    }
}
