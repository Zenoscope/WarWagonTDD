using NUnit.Framework;

namespace EntityTests
{
    public class EntityTests
    {

      private Entity.Entity myEntity;
      int moveAmount = 10;
      // int Health = 100;
      int MaxHealth = 100;
      int injuryAmount = 25;

      [SetUp]
      public void Setup()
      {
          myEntity = new Entity.Entity();
      }

      [Test]
      public void setXSpawnLoc(){
        Assert.That(myEntity.set_x_spawn(),Is.EqualTo(0));
      }

      [Test]
      public void setYSpawnLoc(){
        Assert.That(myEntity.set_y_spawn(),Is.EqualTo(0));
      }

      [Test]
      // get
      public void getEntityXLocation() {
        Assert.That(myEntity.get_x_loc(),Is.EqualTo(0));
      }

      [Test]
      public void getEntityYLocation() {
        Assert.That(myEntity.get_y_loc(),Is.EqualTo(0));
      }

      [Test]
      // set
      public void setEntityXLocation() {
        Assert.That(myEntity.set_x_loc(moveAmount),Is.EqualTo(moveAmount));
      }

      [Test]
      public void setEntityYLocation() {
        Assert.That(myEntity.set_y_loc(moveAmount),Is.EqualTo(moveAmount));
      }


      [Test]
      public void getEntityXLocationAgain() {
        Assert.That(myEntity.get_x_loc(),Is.EqualTo(10));
      }

      [Test]
      public void getEntityYLocationAgain() {
        Assert.That(myEntity.get_y_loc(),Is.EqualTo(10));
      }
      
/*
      [Test]
      public void setNewEntityXLocation() {
        Assert.That(myEntity.set_x_loc(-20),Is.EqualTo(-10));
      }
/*
      [Test]
      public void getNewEntityYLocation() {
        Assert.That(myEntity.get_y_loc(),Is.EqualTo(10));
      }

      [Test]
      // Health
      public void setEntityTotalHealth() {
        Assert.That(myEntity.setTotalHealth(MaxHealth),Is.EqualTo(100));
      }

      [Test]
      public void getEntityHealth() {
        Assert.That(myEntity.getHealth(),Is.EqualTo(100));
      }

      /*
      public void subtractFromEntityHealth() {
        Assert.That(myEntity.subtractFromHealth(injuryAmount),Is.EqualTo(75));
      }
      */


      // set health

      // set mesh
      // get mesh (not sure why though?)

      // set/get list of injury animations?
      // play movevement animations?


    }
}
