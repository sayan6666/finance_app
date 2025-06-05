using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Message_Model : MonoBehaviour
{
    public static GameObject Next_Button;
    public static GameObject Exit_Button;
    public static bool is_checked;
    public static List<(string, string, int)> dialogue;

    public static void Buttons_Active()
    {
        Next_Button.SetActive(!Next_Button.activeSelf);
        Exit_Button.SetActive(!Exit_Button.activeSelf);
    }
    public static void AddMessage(string message, int amount, string align, bool seen)
    {
        is_checked = seen;
        if (amount==0)
        GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().SetText("<align="+align+">"+message+"\n");
        else
            GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().SetText(GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().text + "\n\n"+"<align=" + align + ">" + message);
        //Debug.Log(GameObject.Find("Message_Origin").GetComponent<TextMeshPro>().textInfo.lineCount);
        /* var New_Message = GameObject.Instantiate(GameObject.Find("Message_Origin"));
         New_Message.transform .SetParent(GameObject.Find("Message_Screen").transform, true);
         New_Message.GetComponent<TextMeshPro>().SetText(message);
         var Pos_Rot = GameObject.Find("Message_Origin").GetComponent<RectTransform>();
         New_Message.GetComponent<RectTransform>().SetPositionAndRotation(new Vector3(Pos_Rot.position.x,Pos_Rot.position.y-amount, Pos_Rot.position.z),new Quaternion(0,0,0,0));*/
        //New_Message.GetComponent<RectTransform>().rect.Set(0,-0.332f, 81.9185f, 0.665f);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogue = new List<(string, string, int)>();
        CreateDialogue();
        is_checked = false;
        Next_Button = GameObject.Find("Next_Button"); ;
        Exit_Button = GameObject.Find("Exit_Message_Button");
        AddMessage(dialogue[0].Item1,0, "left", false); 
        scripte.messages++;
    }

    /*0 - ожидание кнопкт далее
     1 - задрежка 1 секунда
    2 - ожидание выбора
    3 - конец*/
    public void CreateDialogue()
    {
        dialogue.Add(("Привет! Рад, что ты решил начать путь в мир инвестиций. Инвестирование — это процесс использования твоих средств для получения прибыли. Но для начала давай разберём несколько базовых понятий. Готов?","left",0));
        dialogue.Add(("Да, готов!",  "right",1));
        dialogue.Add(("Отлично! Начнём с самого простого. Инвестирование — это не то же самое, что сбережения. Когда ты кладёшь деньги на банковский счёт, они просто лежат там и не растут. А вот инвестирование подразумевает, что ты вкладываешь деньги в активы, такие как акции, облигации или недвижимость, с целью их роста.", "left", 0));
        dialogue.Add(("Понял. А что такое активы?", "right", 1));
        dialogue.Add(("Активы — это всё, что может приносить прибыль. Например, если ты покупаешь акции компании, ты становишься её владельцем. Когда компания зарабатывает, ты можешь получать часть прибыли в виде дивидендов или в случае роста стоимости акций продать их за большую цену. К активам также относятся облигации, недвижимость, товары, криптовалюты и другие инвестиционные инструменты.", "left", 0));
        dialogue.Add(("То есть, я могу заработать на росте стоимости акций?", "right", 1));
        dialogue.Add(("Точно! Рост стоимости акций — это один из способов заработать. Но также стоит помнить, что цена акций может и падать. Инвестирование связано с рисками. Вот почему важно понимать, как выбрать правильные активы.", "left", 0));
        dialogue.Add(("А как же выбрать правильные активы?", "right", 1));
        dialogue.Add(("Хороший вопрос! Есть два основных способа оценки активов: <b>фундаментальный анализ</b> и <b>технический анализ</b>. Фундаментальный анализ помогает понять, насколько компания или актив здоровы с точки зрения финансов и будущего роста. Технический анализ — это когда ты изучаешь графики и прошлое поведение цен, чтобы предсказать будущее движение.\r\n", "left", 0));
        dialogue.Add(("Звучит интересно. А как понять, что риски не слишком высоки?", "right", 1));
        dialogue.Add(("Отлично, что ты спросил! Один из способов управления рисками — это <b>диверсификация</b>. Это означает, что ты не должен вкладывать все свои деньги в один актив или одну компанию. Лучше распределить их между различными активами, чтобы снизить риски потерь.", "left", 0));
        dialogue.Add(("То есть, если один актив упадёт, другие могут помочь сбалансировать потери?", "right", 1));
        dialogue.Add(("Именно! Это очень важная стратегия.И помни, что инвестирование — это долгосрочный процесс.Чем больше времени ты можешь позволить своим деньгам расти, тем больше шансов на успех.", "left", 0));
        dialogue.Add(("Хорошо, это понятно. Что мне делать дальше?", "right", 1));
        dialogue.Add(("Прежде чем ты начнёшь выбирать акции, давай немного разберёмся с тем, что означают основные характеристики, которые помогут тебе оценить компанию.Когда ты смотришь на акцию, важно обратить внимание на несколько ключевых показателей:\n• <b>Цена акции</b>: Это стоимость одной акции компании.Например, если цена акции компании составляет $50, это означает, что тебе нужно потратить $50, чтобы купить одну акцию этой компании.Цена акции может изменяться в зависимости от множества факторов.\n• <b>P / E(Price - to - Earnings)</b>: Это коэффициент цена / прибыль.Он показывает, сколько инвесторы готовы платить за каждый доллар прибыли компании.Например, если P / E равен 15, это значит, что инвесторы готовы платить $15 за каждый $1 прибыли компании.Чем ниже P / E, тем, как правило, менее переоценена компания.Но важно помнить, что высокие значения P / E могут свидетельствовать о высоких ожиданиях роста компании.\n• <b>Дивидендная доходность</b>: Это процент, который ты можешь получать от инвестиций в виде дивидендов.Например, если дивидендная доходность компании составляет 4 %, это значит, что ежегодно ты будешь получать 4 % от стоимости своей акции в виде дивидендов.Это важно для инвесторов, которые ищут регулярный доход.\n• <b>Рост прибыли за последний год</b>: Этот показатель показывает, насколько увеличилась прибыль компании за последний год.Например, если рост прибыли составил 25 %, это означает, что компания смогла увеличить свою прибыль на 25 % по сравнению с предыдущим годом.Это хорошая индикаторная характеристика для оценки потенциала роста компании.", "left", 1));
        dialogue.Add(("Теперь, когда ты понял основные характеристики, мы можем перейти к выбору акций.Ты увидишь несколько компаний с разными показателями.Твоя задача — выбрать ту, которая, на твой взгляд, обладает наибольшим потенциалом. Готов?", "left", 0));
        dialogue.Add(("Для этого вернись на главный экран и выбери понравившуюся акцию. Нажми на нее, чтобы увидеть основные характеристики и используй полученную информацию при выборе.", "left", 1));
        dialogue.Add(("После покупки акции не забудь нажать кнопку перемотки времени в верхнем меню — так ты увидишь, как изменится её цена!", "left", 3));
    }

    // Update is called once per frame
    void Update()
    {

    }
}
