// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.BlackboardParameterMapper
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public sealed class BlackboardParameterMapper : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseOverride;
    private static readonly System.IntPtr NativeFieldInfoPtr__Version;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultValue;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentVersion_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_BlackboardParameterMapper_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetDeterministicHash_Public_Int32_Object_0;

    public unsafe int CurrentVersion
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlackboardParameterMapper.NativeMethodInfoPtr_get_CurrentVersion_Public_get_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1094258, XrefRangeEnd = 1094259, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe BlackboardParameterMapper CreateNew(string guid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(guid);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(BlackboardParameterMapper.NativeMethodInfoPtr_CreateNew_Public_Static_BlackboardParameterMapper_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new BlackboardParameterMapper(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlackboardParameterMapper.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1094266, RefRangeEnd = 1094267, XrefRangeStart = 1094259, XrefRangeEnd = 1094266, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetDeterministicHash(UnityEngine.Object sourceAsset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) sourceAsset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(BlackboardParameterMapper.NativeMethodInfoPtr_GetDeterministicHash_Public_Int32_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static BlackboardParameterMapper()
    {
      Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (BlackboardParameterMapper));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr);
      BlackboardParameterMapper.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, nameof (Guid));
      BlackboardParameterMapper.NativeFieldInfoPtr_UseOverride = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, nameof (UseOverride));
      BlackboardParameterMapper.NativeFieldInfoPtr__Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, nameof (_Version));
      BlackboardParameterMapper.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, nameof (DefaultValue));
      BlackboardParameterMapper.NativeMethodInfoPtr_get_CurrentVersion_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, 100686743);
      BlackboardParameterMapper.NativeMethodInfoPtr_CreateNew_Public_Static_BlackboardParameterMapper_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, 100686744);
      BlackboardParameterMapper.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, 100686745);
      BlackboardParameterMapper.NativeMethodInfoPtr_GetDeterministicHash_Public_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, 100686746);
    }

    public BlackboardParameterMapper(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public BlackboardParameterMapper()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterMapper>.NativeClassPtr, data));
    }

    public unsafe string Guid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterMapper.NativeFieldInfoPtr_Guid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterMapper.NativeFieldInfoPtr_Guid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool UseOverride
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterMapper.NativeFieldInfoPtr_UseOverride));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterMapper.NativeFieldInfoPtr_UseOverride)) = value;
      }
    }

    public unsafe int _Version
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterMapper.NativeFieldInfoPtr__Version));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterMapper.NativeFieldInfoPtr__Version)) = value;
      }
    }

    public unsafe SocketDefaultValue DefaultValue
    {
      get
      {
        return *(SocketDefaultValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterMapper.NativeFieldInfoPtr_DefaultValue));
      }
      [param: In] set
      {
        *(SocketDefaultValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BlackboardParameterMapper.NativeFieldInfoPtr_DefaultValue)) = value;
      }
    }
  }
}
