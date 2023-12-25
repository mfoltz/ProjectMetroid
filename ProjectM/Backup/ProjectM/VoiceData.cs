﻿// Decompiled with JetBrains decompiler
// Type: ProjectM.VoiceData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class VoiceData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceMapping;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceMappingFemale;
    private static readonly System.IntPtr NativeFieldInfoPtr_RandomOptions;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1082149, XrefRangeEnd = 1082160, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VoiceData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VoiceData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VoiceData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VoiceData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VoiceData()
    {
      Il2CppClassPointerStore<VoiceData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VoiceData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VoiceData>.NativeClassPtr);
      VoiceData.NativeFieldInfoPtr_VoiceMapping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, nameof (VoiceMapping));
      VoiceData.NativeFieldInfoPtr_VoiceMappingFemale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, nameof (VoiceMappingFemale));
      VoiceData.NativeFieldInfoPtr_RandomOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, nameof (RandomOptions));
      VoiceData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, 100685219);
      VoiceData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VoiceData>.NativeClassPtr, 100685220);
    }

    public VoiceData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe VoiceMapping VoiceMapping
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceData.NativeFieldInfoPtr_VoiceMapping));
        return pointer == System.IntPtr.Zero ? (VoiceMapping) null : new VoiceMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceData.NativeFieldInfoPtr_VoiceMapping), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe VoiceMapping VoiceMappingFemale
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceData.NativeFieldInfoPtr_VoiceMappingFemale));
        return pointer == System.IntPtr.Zero ? (VoiceMapping) null : new VoiceMapping(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceData.NativeFieldInfoPtr_VoiceMappingFemale), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppReferenceArray<VoiceMapping> RandomOptions
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VoiceData.NativeFieldInfoPtr_RandomOptions));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<VoiceMapping>) null : new Il2CppReferenceArray<VoiceMapping>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VoiceData.NativeFieldInfoPtr_RandomOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
