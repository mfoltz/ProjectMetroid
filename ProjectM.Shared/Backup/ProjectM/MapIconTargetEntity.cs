// Decompiled with JetBrains decompiler
// Type: ProjectM.MapIconTargetEntity
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using ProjectM.Network;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapIconTargetEntity
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_TargetNetworkId;
    [FieldOffset(0)]
    public NetworkedEntity TargetEntity;
    [FieldOffset(12)]
    public NetworkId TargetNetworkId;

    static MapIconTargetEntity()
    {
      Il2CppClassPointerStore<MapIconTargetEntity>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MapIconTargetEntity));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapIconTargetEntity>.NativeClassPtr);
      MapIconTargetEntity.NativeFieldInfoPtr_TargetEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconTargetEntity>.NativeClassPtr, nameof (TargetEntity));
      MapIconTargetEntity.NativeFieldInfoPtr_TargetNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapIconTargetEntity>.NativeClassPtr, nameof (TargetNetworkId));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapIconTargetEntity>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
