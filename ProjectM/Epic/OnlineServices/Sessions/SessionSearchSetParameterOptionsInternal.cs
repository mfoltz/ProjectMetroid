// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Sessions.SessionSearchSetParameterOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Sessions
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SessionSearchSetParameterOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Parameter;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ComparisonOp;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Parameter_Public_set_Void_Nullable_1_AttributeData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionSearchSetParameterOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionSearchSetParameterOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_Parameter;
    [FieldOffset(16)]
    public ComparisonOp m_ComparisonOp;

    public unsafe Il2CppSystem.Nullable<AttributeData> Parameter
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942430, XrefRangeEnd = 942436, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_Parameter_Public_set_Void_Nullable_1_AttributeData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe ComparisonOp ComparisonOp
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 73032, RefRangeEnd = 73040, XrefRangeStart = 73032, XrefRangeEnd = 73040, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 942442, RefRangeEnd = 942444, XrefRangeStart = 942436, XrefRangeEnd = 942442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref SessionSearchSetParameterOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionSearchSetParameterOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942444, XrefRangeEnd = 942456, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<SessionSearchSetParameterOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionSearchSetParameterOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 942456, XrefRangeEnd = 942460, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SessionSearchSetParameterOptionsInternal()
    {
      Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Sessions", nameof (SessionSearchSetParameterOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr);
      SessionSearchSetParameterOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      SessionSearchSetParameterOptionsInternal.NativeFieldInfoPtr_m_Parameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, nameof (m_Parameter));
      SessionSearchSetParameterOptionsInternal.NativeFieldInfoPtr_m_ComparisonOp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, nameof (m_ComparisonOp));
      SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_Parameter_Public_set_Void_Nullable_1_AttributeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666594);
      SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_set_ComparisonOp_Public_set_Void_ComparisonOp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666595);
      SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_SessionSearchSetParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666596);
      SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_SessionSearchSetParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666597);
      SessionSearchSetParameterOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, 100666598);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionSearchSetParameterOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
