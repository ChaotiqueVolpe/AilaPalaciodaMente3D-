﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateEnemyChoice 
{
    private EnemyActionChoice enemyActionChooseScript = new EnemyActionChoice();
    public BaseAction acaoDoInimigo;
    private int inimIndex;

    


    public void EnemyCompleteTurn()
    {
        inimIndex = 0; //sempre reseta para o primeiro, porém ...

        if (BattleHandler.inimigosList.Count > 0)
        {
            foreach (Inimigo inimstat in BattleHandler.inimigosList)
            {
                if (inimstat.Agiu)
                {
                    inimIndex++; //...sempre que encontra um inimigo que já agiu ele adiciona 1 no indexador
                    BattleHandler.inimigoTerminouTurno = true;
                }
                else
                {

                    //e quando encontra um que não agiu, significa que o turno dos inimigos ainda não acabou
                    BattleHandler.inimigoTerminouTurno = false;
                }
            }
            //escolher uma ação
            if (inimIndex < BattleHandler.inimigosList.Count)
            {
                BattleHandler.inimigodavez = BattleHandler.inimigosList[inimIndex]; //Salva o inimigo que vai agir em "inimigodavez" do BattleHandler, o script central, que vai por sua vez mandar os status do inimigo junto com a ação escolhida 

                if (!BattleHandler.inimigodavez.Atordoado) //Apenas vai escolher uma ação se não estiver atordoado. Se estiver, não faz nada
                {
                    acaoDoInimigo = enemyActionChooseScript.ChooseEnemyAction(BattleHandler.inimigodavez);
                    BattleHandler.enemyUsedAction = acaoDoInimigo;
                }
            }
        }

            //calcular dano
            BattleHandler.currentState = BattleHandler.BattleStates.CALCDAMAGE;
            //fim de turno
        
        
    }

}
