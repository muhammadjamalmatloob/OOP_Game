using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace OOPFinal.BL
{
    public abstract class Character
    {
        protected string name;
        protected PictureBox character;
        protected ProgressBar Health;
        protected int AttackPower;
        protected int Speed;
        protected int BackSpeed;
        protected int InitialY = 297;

        public Character()
        {

        }
        public Character(string name, PictureBox character, ProgressBar Health, int AttackPower, int Speed, int BackSpeed)
        {
            this.name = name;
            this.character = character;
            this.Health = Health;
            this.AttackPower = AttackPower;
            this.Speed = Speed;
            this.BackSpeed = BackSpeed;
        }
        public virtual string GetName()
        {
            return name;
        }
        public virtual void SetName(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }
            name = value;
        }
        public virtual Image GetCharacter()
        {
            return character.Image;
        }
        public virtual void SetCharacter(Image value)
        {
            if (value == null)
            {
                throw new ArgumentException("Character cannot be null.");
            }
            character.Image = value;
        }
        public virtual int GetHealth()
        {
            return Health.Value;
        }
        public virtual void SetHealth(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health cannot be negative.");
            }
            Health.Value = value;
        }
        public virtual int GetAttackPowerValue()
        {
            return AttackPower;
        }
        public virtual void SetAttackPowerValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("AttackPower cannot be negative.");
            }
            AttackPower = value;
        }
        public virtual int GetSpeedValue()
        {
            return Speed;
        }
        public virtual void SetSpeedValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Speed cannot be negative.");
            }
            Speed = value;
        }
        public virtual int GetBackSpeedValue()
        {
            return BackSpeed;
        }
        public virtual void SetBackSpeedValue(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("BackSpeed cannot be negative.");
            }
            BackSpeed = value;
        }

        public virtual void MoveLeft()
        {
            if ((character.Location.X - Speed) > 123)
            {
                character.Location = new Point(123, character.Location.Y);
            }
            if (character.Location.X > 123)
            {
                character.Location = new Point(character.Location.X - Speed, character.Location.Y);
            }
            
        }

        public virtual void MoveRight()
        {
            if ((character.Location.X + Speed) > 767)
            {
                character.Location = new Point(767, character.Location.Y);
            }
            else if (character.Location.X < 767)
            {
                character.Location = new Point(character.Location.X + Speed, character.Location.Y);
            }
        }

       
        
    }

    
    
}