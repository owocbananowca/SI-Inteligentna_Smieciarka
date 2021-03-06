﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.TrashGenerator.AllTrashs;
using Assets.TrashGenerator.AllTrashs.Interfaces;

namespace Assets.TrashGenerator.AllTrashs.KindOfTrash {
     class Paper : Trashs {

          private int _weight;
          private int _abilityOfCrushing;
          private int _absorptionOfHeat;
          private string _typeOfTrash;
          
          public Paper() {

          }
          public Paper(int weight = 0, int abilityOfCrushing = 0, int absorptionOfHeat = 0, string typeOfTrash = "") {

               this._weight = weight;
               this._abilityOfCrushing = abilityOfCrushing;
               this._absorptionOfHeat = absorptionOfHeat;
               this._typeOfTrash = typeOfTrash;
          }

          override public int Weight {
               get { return this._weight; }
               set { this._weight = value; }
          }
          override public int AbilityOfCrushing {
               get { return this._abilityOfCrushing; }
               set { this._abilityOfCrushing = value; }
          }
          override public int AbsorptionOfHeat {
               get { return this._absorptionOfHeat; }
               set { this._absorptionOfHeat = value; }
          }
          override public string TypeOfTrash {
               get { return _typeOfTrash; }
               set { this._typeOfTrash = value; }
          }
          override public int SizeOfTrash { get; set; }

     }
}
