// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.Snapshot_Script_LightningProjectile_Nodes
// Assembly: ProjectM.GeneratedNetCode, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 974A3FD3-059B-42E2-9255-83E537AA7BC4
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.GeneratedNetCode.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Snapshot_Script_LightningProjectile_Nodes
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Age;
    private static readonly System.IntPtr NativeFieldInfoPtr_AngleDiff;
    [FieldOffset(0)]
    public float Age;
    [FieldOffset(4)]
    public float AngleDiff;

    static Snapshot_Script_LightningProjectile_Nodes()
    {
      Il2CppClassPointerStore<Snapshot_Script_LightningProjectile_Nodes>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.GeneratedNetCode.dll", "ProjectM.Network", nameof (Snapshot_Script_LightningProjectile_Nodes));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Snapshot_Script_LightningProjectile_Nodes>.NativeClassPtr);
      Snapshot_Script_LightningProjectile_Nodes.NativeFieldInfoPtr_Age = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_Script_LightningProjectile_Nodes>.NativeClassPtr, nameof (Age));
      Snapshot_Script_LightningProjectile_Nodes.NativeFieldInfoPtr_AngleDiff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Snapshot_Script_LightningProjectile_Nodes>.NativeClassPtr, nameof (AngleDiff));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Snapshot_Script_LightningProjectile_Nodes>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
