// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.AntiCheatCommon.LogEventParamPair
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
  public sealed class LogEventParamPair : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__ParamValue_k__BackingField;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParamValue_Public_get_LogEventParamPairParamValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ParamValue_Public_set_Void_LogEventParamPairParamValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Internal_Void_byref_LogEventParamPairInternal_0;

    public unsafe LogEventParamPairParamValue ParamValue
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(LogEventParamPair.NativeMethodInfoPtr_get_ParamValue_Public_get_LogEventParamPairParamValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return new LogEventParamPairParamValue(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 969441, XrefRangeEnd = 969442, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(LogEventParamPair.NativeMethodInfoPtr_set_ParamValue_Public_set_Void_LogEventParamPairParamValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 969449, RefRangeEnd = 969450, XrefRangeStart = 969442, XrefRangeEnd = 969449, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Set(ref LogEventParamPairInternal other)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LogEventParamPair.NativeMethodInfoPtr_Set_Internal_Void_byref_LogEventParamPairInternal_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LogEventParamPair()
    {
      Il2CppClassPointerStore<LogEventParamPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.AntiCheatCommon", nameof (LogEventParamPair));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LogEventParamPair>.NativeClassPtr);
      LogEventParamPair.NativeFieldInfoPtr__ParamValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LogEventParamPair>.NativeClassPtr, "<ParamValue>k__BackingField");
      LogEventParamPair.NativeMethodInfoPtr_get_ParamValue_Public_get_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPair>.NativeClassPtr, 100673938);
      LogEventParamPair.NativeMethodInfoPtr_set_ParamValue_Public_set_Void_LogEventParamPairParamValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPair>.NativeClassPtr, 100673939);
      LogEventParamPair.NativeMethodInfoPtr_Set_Internal_Void_byref_LogEventParamPairInternal_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LogEventParamPair>.NativeClassPtr, 100673940);
    }

    public LogEventParamPair(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public LogEventParamPair()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LogEventParamPair>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogEventParamPair>.NativeClassPtr, data));
    }

    public LogEventParamPairParamValue _ParamValue_k__BackingField
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPair.NativeFieldInfoPtr__ParamValue_k__BackingField);
        return new LogEventParamPairParamValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LogEventParamPair.NativeFieldInfoPtr__ParamValue_k__BackingField), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LogEventParamPairParamValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
