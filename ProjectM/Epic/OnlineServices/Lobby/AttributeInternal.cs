// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Lobby.AttributeInternal
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
  public struct AttributeInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Visibility;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Data_Public_get_Nullable_1_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Nullable_1_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Visibility_Public_get_LobbyAttributeVisibility_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Attribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Attribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Attribute_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Data;
    [FieldOffset(16)]
    public LobbyAttributeVisibility m_Visibility;

    public unsafe Il2CppSystem.Nullable<AttributeData> Data
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953761, XrefRangeEnd = 953767, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(AttributeInternal.NativeMethodInfoPtr_get_Data_Public_get_Nullable_1_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new Il2CppSystem.Nullable<AttributeData>(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953767, XrefRangeEnd = 953773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_Nullable_1_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe LobbyAttributeVisibility Visibility
    {
      [CallerCount(5), CachedScanResults(RefRangeStart = 23501, RefRangeEnd = 23506, XrefRangeStart = 23501, XrefRangeEnd = 23506, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeInternal.NativeMethodInfoPtr_get_Visibility_Public_get_LobbyAttributeVisibility_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(LobbyAttributeVisibility*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AttributeInternal.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953773, XrefRangeEnd = 953779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Attribute other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Attribute_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953779, XrefRangeEnd = 953791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<Attribute> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Attribute_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953791, XrefRangeEnd = 953795, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 953796, RefRangeEnd = 953797, XrefRangeStart = 953795, XrefRangeEnd = 953796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out Attribute output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AttributeInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Attribute_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref Attribute local = ref output;
      System.IntPtr pointer = zero;
      Attribute attribute = pointer == System.IntPtr.Zero ? (Attribute) null : new Attribute(pointer);
      local = attribute;
    }

    static AttributeInternal()
    {
      Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Lobby", nameof (AttributeInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr);
      AttributeInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, nameof (m_ApiVersion));
      AttributeInternal.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, nameof (m_Data));
      AttributeInternal.NativeFieldInfoPtr_m_Visibility = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, nameof (m_Visibility));
      AttributeInternal.NativeMethodInfoPtr_get_Data_Public_get_Nullable_1_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, 100669621);
      AttributeInternal.NativeMethodInfoPtr_set_Data_Public_set_Void_Nullable_1_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, 100669622);
      AttributeInternal.NativeMethodInfoPtr_get_Visibility_Public_get_LobbyAttributeVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, 100669623);
      AttributeInternal.NativeMethodInfoPtr_set_Visibility_Public_set_Void_LobbyAttributeVisibility_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, 100669624);
      AttributeInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, 100669625);
      AttributeInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, 100669626);
      AttributeInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, 100669627);
      AttributeInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_Attribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, 100669628);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttributeInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
