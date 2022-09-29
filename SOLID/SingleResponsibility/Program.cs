//Her nesnenin bir sorumluluğu olmalı.

//Bir yazılmcı neyden sorumludur?
/*
 *  YAGNI: You ain't gonna need it!
 *  Senaryo: Masaüstü form uygulaması aracılığıyla ürün CRUD işlemlerini yapan uygulama.... 
 *           Yeni ürün eklendiğinde e-posta atılması isteği geldi
 *    - Kullanıcı ara yüzü.. -> Kullanıcıdan değer alır ve sonucu gösterir.
 *    - Yapılacak işlemler (business) -> Kullanıcının aksiyonuna göre çağrılan belirli hedefe yönelik eylemler
 *    - Veritabanı işlemleri (data) -> business'dan gelen talepleri; db ile çözen bileşen.... 
 *    - Uygulama notification gönderebilir
      - Notification: Email, SMS, Slack ya da BİP

 *  Open-Closed Principle: 
 */
public class Developer
{
    public void WriteCode() { }

    public void DesignNewProject() { }

    public void WriteUnitTest() { }

    public void DeployProject() { }

    public void MaintainDatabase() { }

    //bunun burada işi ne?
    public void CreateBill() { }

}

