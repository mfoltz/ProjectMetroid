// Decompiled with JetBrains decompiler
// Type: ProjectM.TraderItemData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TraderItemData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCostGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemCostAmount;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutItemGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutItemAmount;
    [FieldOffset(0)]
    public Entity Entity;
    [FieldOffset(8)]
    public PrefabGUID Guid;
    [FieldOffset(12)]
    public PrefabGUID ItemCostGuid;
    [FieldOffset(16)]
    public int ItemCostAmount;
    [FieldOffset(20)]
    public PrefabGUID OutItemGuid;
    [FieldOffset(24)]
    public int OutItemAmount;

    static TraderItemData()
    {
      Il2CppClassPointerStore<TraderItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TraderItemData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TraderItemData>.NativeClassPtr);
      TraderItemData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemData>.NativeClassPtr, nameof (Entity));
      TraderItemData.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemData>.NativeClassPtr, nameof (Guid));
      TraderItemData.NativeFieldInfoPtr_ItemCostGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemData>.NativeClassPtr, nameof (ItemCostGuid));
      TraderItemData.NativeFieldInfoPtr_ItemCostAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemData>.NativeClassPtr, nameof (ItemCostAmount));
      TraderItemData.NativeFieldInfoPtr_OutItemGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemData>.NativeClassPtr, nameof (OutItemGuid));
      TraderItemData.NativeFieldInfoPtr_OutItemAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TraderItemData>.NativeClassPtr, nameof (OutItemAmount));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TraderItemData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
