// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.RegisterEventParamDefInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.AntiCheatCommon
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RegisterEventParamDefInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ParamType;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamName_Public_get_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamType_Public_get_AntiCheatCommonEventParamType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamType_Public_set_Void_AntiCheatCommonEventParamType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterEventParamDef_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterEventParamDef_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_RegisterEventParamDef_0;
    [FieldOffset(0)]
    public System.IntPtr m_ParamName;
    [FieldOffset(8)]
    public AntiCheatCommonEventParamType m_ParamType;

    public unsafe Epic.OnlineServices.Utf8String ParamName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970724, XrefRangeEnd = 970728, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_get_ParamName_Public_get_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970728, XrefRangeEnd = 970732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_set_ParamName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe AntiCheatCommonEventParamType ParamType
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_get_ParamType_Public_get_AntiCheatCommonEventParamType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AntiCheatCommonEventParamType*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_set_ParamType_Public_set_Void_AntiCheatCommonEventParamType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970732, XrefRangeEnd = 970736, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref RegisterEventParamDef other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterEventParamDef_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970736, XrefRangeEnd = 970746, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<RegisterEventParamDef> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterEventParamDef_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970746, XrefRangeEnd = 970750, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 970750, XrefRangeEnd = 970751, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out RegisterEventParamDef output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RegisterEventParamDefInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_RegisterEventParamDef_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref RegisterEventParamDef local = ref output;
      System.IntPtr pointer = zero;
      RegisterEventParamDef registerEventParamDef = pointer == System.IntPtr.Zero ? (RegisterEventParamDef) null : new RegisterEventParamDef(pointer);
      local = registerEventParamDef;
    }

    static RegisterEventParamDefInternal()
    {
      Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (RegisterEventParamDefInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr);
      RegisterEventParamDefInternal.NativeFieldInfoPtr_m_ParamName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, nameof (m_ParamName));
      RegisterEventParamDefInternal.NativeFieldInfoPtr_m_ParamType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, nameof (m_ParamType));
      RegisterEventParamDefInternal.NativeMethodInfoPtr_get_ParamName_Public_get_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100674277);
      RegisterEventParamDefInternal.NativeMethodInfoPtr_set_ParamName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100674278);
      RegisterEventParamDefInternal.NativeMethodInfoPtr_get_ParamType_Public_get_AntiCheatCommonEventParamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100674279);
      RegisterEventParamDefInternal.NativeMethodInfoPtr_set_ParamType_Public_set_Void_AntiCheatCommonEventParamType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100674280);
      RegisterEventParamDefInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100674281);
      RegisterEventParamDefInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100674282);
      RegisterEventParamDefInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100674283);
      RegisterEventParamDefInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_RegisterEventParamDef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, 100674284);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RegisterEventParamDefInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
