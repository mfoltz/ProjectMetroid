// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Scripting.Script_LightningProjectile_Nodes
// Assembly: ProjectM.Gameplay.Scripting, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 87A11602-D28B-4E70-A33D-8BBFD694EEEF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Gameplay.Scripting.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Scripting
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Script_LightningProjectile_Nodes
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Age;
    private static readonly System.IntPtr NativeFieldInfoPtr_AngleDiff;
    [FieldOffset(0)]
    public float Age;
    [FieldOffset(4)]
    public float AngleDiff;

    static Script_LightningProjectile_Nodes()
    {
      Il2CppClassPointerStore<Script_LightningProjectile_Nodes>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Scripting.dll", "ProjectM.Gameplay.Scripting", nameof (Script_LightningProjectile_Nodes));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Script_LightningProjectile_Nodes>.NativeClassPtr);
      Script_LightningProjectile_Nodes.NativeFieldInfoPtr_Age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_Nodes>.NativeClassPtr, nameof (Age));
      Script_LightningProjectile_Nodes.NativeFieldInfoPtr_AngleDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Script_LightningProjectile_Nodes>.NativeClassPtr, nameof (AngleDiff));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Script_LightningProjectile_Nodes>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
