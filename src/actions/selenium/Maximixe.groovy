package actions.selenium;

import actions.selenium.Browser

class Maximixe{
    public void run(def params){
        Browser.Driver.manage().window().maximize()
    }
}