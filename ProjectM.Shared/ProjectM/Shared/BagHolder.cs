// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.BagHolder
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BagHolder
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BagInstance0;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagInstance1;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagInstance2;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagInstance3;
    private static readonly System.IntPtr NativeFieldInfoPtr_BagSlots;
    private static readonly System.IntPtr NativeFieldInfoPtr_Capacity;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsValidSlot_Public_Boolean_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_BagInstance_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_BagInstance_0;
    [FieldOffset(0)]
    public BagInstance BagInstance0;
    [FieldOffset(16)]
    public BagInstance BagInstance1;
    [FieldOffset(32)]
    public BagInstance BagInstance2;
    [FieldOffset(48)]
    public BagInstance BagInstance3;
    [FieldOffset(64)]
    public int BagSlots;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 797100, RefRangeEnd = 797101, XrefRangeStart = 797100, XrefRangeEnd = 797100, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsValidSlot(int slot)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &slot;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BagHolder.NativeMethodInfoPtr_IsValidSlot_Public_Boolean_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    public unsafe BagInstance this[int index]
    {
      [CallerCount(21), CachedScanResults(RefRangeStart = 797101, RefRangeEnd = 797122, XrefRangeStart = 797101, XrefRangeEnd = 797101, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BagHolder.NativeMethodInfoPtr_get_Item_Public_get_BagInstance_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(BagInstance*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(6), CachedScanResults(RefRangeStart = 797122, RefRangeEnd = 797128, XrefRangeStart = 797122, XrefRangeEnd = 797122, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &index;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(BagHolder.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_BagInstance_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static BagHolder()
    {
      Il2CppClassPointerStore<BagHolder>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (BagHolder));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BagHolder>.NativeClassPtr);
      BagHolder.NativeFieldInfoPtr_BagInstance0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, nameof (BagInstance0));
      BagHolder.NativeFieldInfoPtr_BagInstance1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, nameof (BagInstance1));
      BagHolder.NativeFieldInfoPtr_BagInstance2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, nameof (BagInstance2));
      BagHolder.NativeFieldInfoPtr_BagInstance3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, nameof (BagInstance3));
      BagHolder.NativeFieldInfoPtr_BagSlots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, nameof (BagSlots));
      BagHolder.NativeFieldInfoPtr_Capacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, nameof (Capacity));
      BagHolder.NativeMethodInfoPtr_IsValidSlot_Public_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, 100670337);
      BagHolder.NativeMethodInfoPtr_get_Item_Public_get_BagInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, 100670338);
      BagHolder.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_BagInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, 100670339);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BagHolder>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int Capacity
    {
      get
      {
        int capacity;
        IL2CPP.il2cpp_field_static_get_value(BagHolder.NativeFieldInfoPtr_Capacity, (void*) &capacity);
        return capacity;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(BagHolder.NativeFieldInfoPtr_Capacity, (void*) &value);
      }
    }
  }
}
