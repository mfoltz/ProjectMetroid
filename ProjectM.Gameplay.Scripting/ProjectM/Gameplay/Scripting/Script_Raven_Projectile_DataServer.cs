// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_Raven_Projectile_DataServer
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_Raven_Projectile_DataServer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellDamage;
    private static readonly System.IntPtr NativeFieldInfoPtr_Radius;
    private static readonly System.IntPtr NativeFieldInfoPtr_Ticks;
    [FieldOffset(0)]
    public float SpellDamage;
    [FieldOffset(4)]
    public float Radius;
    [FieldOffset(8)]
    public int Ticks;

    static Script_Raven_Projectile_DataServer()
    {
      Il2CppClassPointerStore<Script_Raven_Projectile_DataServer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_Raven_Projectile_DataServer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_Raven_Projectile_DataServer>.NativeClassPtr);
      Script_Raven_Projectile_DataServer.NativeFieldInfoPtr_SpellDamage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Raven_Projectile_DataServer>.NativeClassPtr, nameof (SpellDamage));
      Script_Raven_Projectile_DataServer.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Raven_Projectile_DataServer>.NativeClassPtr, nameof (Radius));
      Script_Raven_Projectile_DataServer.NativeFieldInfoPtr_Ticks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_Raven_Projectile_DataServer>.NativeClassPtr, nameof (Ticks));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_Raven_Projectile_DataServer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
