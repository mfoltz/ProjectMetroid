// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.AttributeDataInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Lobby
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AttributeDataInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Key;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Key_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Value_Public_get_AttributeDataValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_AttributeDataValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AttributeData_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Key;
    [FieldOffset(16)]
    public AttributeDataValueInternal m_Value;

    public unsafe Epic.OnlineServices.Utf8String Key
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953810, XrefRangeEnd = 953814, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_get_Key_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953814, XrefRangeEnd = 953818, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AttributeDataValue Value
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953818, XrefRangeEnd = 953824, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_get_Value_Public_get_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new AttributeDataValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953824, XrefRangeEnd = 953830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_set_Value_Public_set_Void_AttributeDataValue_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 953840, RefRangeEnd = 953841, XrefRangeStart = 953830, XrefRangeEnd = 953840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref AttributeData other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953841, XrefRangeEnd = 953857, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<AttributeData> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953857, XrefRangeEnd = 953864, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953864, XrefRangeEnd = 953865, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out AttributeData output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeDataInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref AttributeData local = ref output;
      System.IntPtr pointer = zero;
      AttributeData attributeData = pointer == System.IntPtr.Zero ? (AttributeData) null : new AttributeData(pointer);
      local = attributeData;
    }

    static AttributeDataInternal()
    {
      Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (AttributeDataInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr);
      AttributeDataInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AttributeDataInternal.NativeFieldInfoPtr_m_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, nameof (m_Key));
      AttributeDataInternal.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, nameof (m_Value));
      AttributeDataInternal.NativeMethodInfoPtr_get_Key_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100669634);
      AttributeDataInternal.NativeMethodInfoPtr_set_Key_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100669635);
      AttributeDataInternal.NativeMethodInfoPtr_get_Value_Public_get_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100669636);
      AttributeDataInternal.NativeMethodInfoPtr_set_Value_Public_set_Void_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100669637);
      AttributeDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100669638);
      AttributeDataInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100669639);
      AttributeDataInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100669640);
      AttributeDataInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, 100669641);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttributeDataInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
