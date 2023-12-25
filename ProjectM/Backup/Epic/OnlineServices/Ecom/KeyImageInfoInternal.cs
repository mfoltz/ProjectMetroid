// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Ecom.KeyImageInfoInternal
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
  public struct KeyImageInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Url;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Width;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Height;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Type_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Url_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Url_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Width_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Width_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Height_Public_get_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Height_Public_set_Void_UInt32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_KeyImageInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_KeyImageInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_KeyImageInfo_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Type;
    [FieldOffset(16)]
    public System.IntPtr m_Url;
    [FieldOffset(24)]
    public uint m_Width;
    [FieldOffset(28)]
    public uint m_Height;

    public unsafe Epic.OnlineServices.Utf8String Type
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963123, XrefRangeEnd = 963127, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_get_Type_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963127, XrefRangeEnd = 963131, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String Url
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963131, XrefRangeEnd = 963135, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_get_Url_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963135, XrefRangeEnd = 963139, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_set_Url_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint Width
    {
      [CallerCount(264), CachedScanResults(RefRangeStart = 39170, RefRangeEnd = 39434, XrefRangeStart = 39170, XrefRangeEnd = 39434, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_get_Width_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(3), CachedScanResults(RefRangeStart = 20483, RefRangeEnd = 20486, XrefRangeStart = 20483, XrefRangeEnd = 20486, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_set_Width_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe uint Height
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 40254, RefRangeEnd = 40255, XrefRangeStart = 40254, XrefRangeEnd = 40255, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_get_Height_Public_get_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(uint*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 70612, RefRangeEnd = 70614, XrefRangeStart = 70612, XrefRangeEnd = 70614, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_set_Height_Public_set_Void_UInt32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963139, XrefRangeEnd = 963147, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref KeyImageInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_KeyImageInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963147, XrefRangeEnd = 963165, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<KeyImageInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_KeyImageInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963165, XrefRangeEnd = 963170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 963170, XrefRangeEnd = 963171, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out KeyImageInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(KeyImageInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_KeyImageInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref KeyImageInfo local = ref output;
      System.IntPtr pointer = zero;
      KeyImageInfo keyImageInfo = pointer == System.IntPtr.Zero ? (KeyImageInfo) null : new KeyImageInfo(pointer);
      local = keyImageInfo;
    }

    static KeyImageInfoInternal()
    {
      Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Ecom", nameof (KeyImageInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr);
      KeyImageInfoInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_ApiVersion));
      KeyImageInfoInternal.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_Type));
      KeyImageInfoInternal.NativeFieldInfoPtr_m_Url = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_Url));
      KeyImageInfoInternal.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_Width));
      KeyImageInfoInternal.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, nameof (m_Height));
      KeyImageInfoInternal.NativeMethodInfoPtr_get_Type_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672156);
      KeyImageInfoInternal.NativeMethodInfoPtr_set_Type_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672157);
      KeyImageInfoInternal.NativeMethodInfoPtr_get_Url_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672158);
      KeyImageInfoInternal.NativeMethodInfoPtr_set_Url_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672159);
      KeyImageInfoInternal.NativeMethodInfoPtr_get_Width_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672160);
      KeyImageInfoInternal.NativeMethodInfoPtr_set_Width_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672161);
      KeyImageInfoInternal.NativeMethodInfoPtr_get_Height_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672162);
      KeyImageInfoInternal.NativeMethodInfoPtr_set_Height_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672163);
      KeyImageInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_KeyImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672164);
      KeyImageInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_KeyImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672165);
      KeyImageInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672166);
      KeyImageInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_KeyImageInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, 100672167);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<KeyImageInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
