// Decompiled with JetBrains decompiler
// Type: ProjectM.InventoryBuffer
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
  public struct InventoryBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_ItemType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Amount;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAmountOverride;
    private static readonly System.IntPtr NativeMethodInfoPtr_Empty_Public_Static_InventoryBuffer_0;
    [FieldOffset(0)]
    public NetworkedEntity ItemEntity;
    [FieldOffset(12)]
    public PrefabGUID ItemType;
    [FieldOffset(16)]
    public int Amount;
    [FieldOffset(20)]
    public int MaxAmountOverride;

    [CallerCount(43)]
    [CachedScanResults(RefRangeStart = 412815, RefRangeEnd = 412858, XrefRangeStart = 412815, XrefRangeEnd = 412858, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe InventoryBuffer Empty()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InventoryBuffer.NativeMethodInfoPtr_Empty_Public_Static_InventoryBuffer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(InventoryBuffer*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InventoryBuffer()
    {
      Il2CppClassPointerStore<InventoryBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InventoryBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InventoryBuffer>.NativeClassPtr);
      InventoryBuffer.NativeFieldInfoPtr_ItemEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryBuffer>.NativeClassPtr, nameof (ItemEntity));
      InventoryBuffer.NativeFieldInfoPtr_ItemType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryBuffer>.NativeClassPtr, nameof (ItemType));
      InventoryBuffer.NativeFieldInfoPtr_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryBuffer>.NativeClassPtr, nameof (Amount));
      InventoryBuffer.NativeFieldInfoPtr_MaxAmountOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InventoryBuffer>.NativeClassPtr, nameof (MaxAmountOverride));
      InventoryBuffer.NativeMethodInfoPtr_Empty_Public_Static_InventoryBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InventoryBuffer>.NativeClassPtr, 100664324);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InventoryBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
