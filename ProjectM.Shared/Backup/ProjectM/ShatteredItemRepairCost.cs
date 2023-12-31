// Decompiled with JetBrains decompiler
// Type: ProjectM.ShatteredItemRepairCost
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ShatteredItemRepairCost
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ToInventoryBuffer_Public_Virtual_Final_New_get_InventoryBuffer_0;
    [FieldOffset(0)]
    public PrefabGUID ItemId;
    [FieldOffset(4)]
    public int Amount;

    public virtual unsafe InventoryBuffer ToInventoryBuffer
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ShatteredItemRepairCost.NativeMethodInfoPtr_get_ToInventoryBuffer_Public_Virtual_Final_New_get_InventoryBuffer_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(InventoryBuffer*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ShatteredItemRepairCost()
    {
      Il2CppClassPointerStore<ShatteredItemRepairCost>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ShatteredItemRepairCost));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShatteredItemRepairCost>.NativeClassPtr);
      ShatteredItemRepairCost.NativeFieldInfoPtr_ItemId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShatteredItemRepairCost>.NativeClassPtr, nameof (ItemId));
      ShatteredItemRepairCost.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShatteredItemRepairCost>.NativeClassPtr, nameof (Amount));
      ShatteredItemRepairCost.NativeMethodInfoPtr_get_ToInventoryBuffer_Public_Virtual_Final_New_get_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShatteredItemRepairCost>.NativeClassPtr, 100665367);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShatteredItemRepairCost>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
