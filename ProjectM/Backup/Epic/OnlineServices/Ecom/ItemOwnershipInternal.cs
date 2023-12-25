// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.ItemOwnershipInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Ecom
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ItemOwnershipInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_OwnershipStatus;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_OwnershipStatus_Public_get_OwnershipStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_OwnershipStatus_Public_set_Void_OwnershipStatus_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ItemOwnership_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ItemOwnership_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ItemOwnership_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Id;
    [FieldOffset(16)]
    public OwnershipStatus m_OwnershipStatus;

    public unsafe Epic.OnlineServices.Utf8String Id
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963084, XrefRangeEnd = 963088, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963088, XrefRangeEnd = 963092, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe OwnershipStatus OwnershipStatus
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_get_OwnershipStatus_Public_get_OwnershipStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(OwnershipStatus*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_set_OwnershipStatus_Public_set_Void_OwnershipStatus_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963092, XrefRangeEnd = 963096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref ItemOwnership other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ItemOwnership_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963096, XrefRangeEnd = 963106, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<ItemOwnership> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ItemOwnership_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963106, XrefRangeEnd = 963110, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 963111, RefRangeEnd = 963112, XrefRangeStart = 963110, XrefRangeEnd = 963111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out ItemOwnership output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ItemOwnershipInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ItemOwnership_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref ItemOwnership local = ref output;
      System.IntPtr pointer = zero;
      ItemOwnership itemOwnership = pointer == System.IntPtr.Zero ? (ItemOwnership) null : new ItemOwnership(pointer);
      local = itemOwnership;
    }

    static ItemOwnershipInternal()
    {
      Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (ItemOwnershipInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr);
      ItemOwnershipInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, nameof (m_ApiVersion));
      ItemOwnershipInternal.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, nameof (m_Id));
      ItemOwnershipInternal.NativeFieldInfoPtr_m_OwnershipStatus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, nameof (m_OwnershipStatus));
      ItemOwnershipInternal.NativeMethodInfoPtr_get_Id_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100672139);
      ItemOwnershipInternal.NativeMethodInfoPtr_set_Id_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100672140);
      ItemOwnershipInternal.NativeMethodInfoPtr_get_OwnershipStatus_Public_get_OwnershipStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100672141);
      ItemOwnershipInternal.NativeMethodInfoPtr_set_OwnershipStatus_Public_set_Void_OwnershipStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100672142);
      ItemOwnershipInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_ItemOwnership_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100672143);
      ItemOwnershipInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_ItemOwnership_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100672144);
      ItemOwnershipInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100672145);
      ItemOwnershipInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_ItemOwnership_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, 100672146);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ItemOwnershipInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
