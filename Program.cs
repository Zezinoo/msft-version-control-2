//Alteraçao V2
new Panda().Marry(new Panda());
public class Panda
{
  public Panda Mate;

  public void Marry(Panda partner)
  {
    Mate = partner;
    partner.Mate = this;
  }
  //Alteração V2.1
}
//Alteração v2.2
