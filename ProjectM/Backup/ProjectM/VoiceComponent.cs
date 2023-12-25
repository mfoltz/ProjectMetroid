// Decompiled with JetBrains decompiler
// Type: ProjectM.VoiceComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class VoiceComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_VoiceMapping;
    private static readonly IntPtr NativeFieldInfoPtr_VoiceMappingFemale;
    private static readonly IntPtr NativeFieldInfoPtr_RandomOptions;
    private static readonly IntPtr NativeFieldInfoPtr_RandomizeVoiceMapping;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082160, XrefRangeEnd = 1082188, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VoiceComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VoiceComponent()
    {
      Il2CppClassPointerStore<VoiceComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VoiceComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceComponent>.NativeClassPtr);
      VoiceComponent.NativeFieldInfoPtr_VoiceMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceComponent>.NativeClassPtr, nameof (VoiceMapping));
      VoiceComponent.NativeFieldInfoPtr_VoiceMappingFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceComponent>.NativeClassPtr, nameof (VoiceMappingFemale));
      VoiceComponent.NativeFieldInfoPtr_RandomOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceComponent>.NativeClassPtr, nameof (RandomOptions));
      VoiceComponent.NativeFieldInfoPtr_RandomizeVoiceMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceComponent>.NativeClassPtr, nameof (RandomizeVoiceMapping));
      VoiceComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceComponent>.NativeClassPtr, 100685221);
      VoiceComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceComponent>.NativeClassPtr, 100685222);
    }

    public VoiceComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe VoiceMapping VoiceMapping
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceComponent.NativeFieldInfoPtr_VoiceMapping));
        return pointer == IntPtr.Zero ? (VoiceMapping) null : new VoiceMapping(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceComponent.NativeFieldInfoPtr_VoiceMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VoiceMapping VoiceMappingFemale
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceComponent.NativeFieldInfoPtr_VoiceMappingFemale));
        return pointer == IntPtr.Zero ? (VoiceMapping) null : new VoiceMapping(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceComponent.NativeFieldInfoPtr_VoiceMappingFemale), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<VoiceMapping> RandomOptions
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceComponent.NativeFieldInfoPtr_RandomOptions));
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<VoiceMapping>) null : new Il2CppReferenceArray<VoiceMapping>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceComponent.NativeFieldInfoPtr_RandomOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool RandomizeVoiceMapping
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceComponent.NativeFieldInfoPtr_RandomizeVoiceMapping));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceComponent.NativeFieldInfoPtr_RandomizeVoiceMapping)) = value;
      }
    }
  }
}
