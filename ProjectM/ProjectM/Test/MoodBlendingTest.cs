// Decompiled with JetBrains decompiler
// Type: ProjectM.Test.MoodBlendingTest
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Presentation;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Test
{
  public class MoodBlendingTest : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Mood1;
    private static readonly IntPtr NativeFieldInfoPtr_Mood2;
    private static readonly IntPtr NativeFieldInfoPtr_BlendPercent;
    private static readonly IntPtr NativeFieldInfoPtr_DayNight;
    private static readonly IntPtr NativeFieldInfoPtr_AdditionalMood;
    private static readonly IntPtr NativeFieldInfoPtr_AdditionalMoodWeight;
    private static readonly IntPtr NativeFieldInfoPtr__Mood1;
    private static readonly IntPtr NativeFieldInfoPtr__Mood2;
    private static readonly IntPtr NativeFieldInfoPtr__AdditionalMoodBlend;
    private static readonly IntPtr NativeFieldInfoPtr_BlendStack;
    private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnBlendMoods_Private_Void_VolumeStack_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164702, XrefRangeEnd = 1164732, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnEnable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodBlendingTest.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164732, XrefRangeEnd = 1164749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDisable()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodBlendingTest.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164749, XrefRangeEnd = 1164835, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnBlendMoods(VolumeStack stack)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stack);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodBlendingTest.NativeMethodInfoPtr_OnBlendMoods_Private_Void_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MoodBlendingTest()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MoodBlendingTest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MoodBlendingTest()
    {
      Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Test", nameof (MoodBlendingTest));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr);
      MoodBlendingTest.NativeFieldInfoPtr_Mood1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (Mood1));
      MoodBlendingTest.NativeFieldInfoPtr_Mood2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (Mood2));
      MoodBlendingTest.NativeFieldInfoPtr_BlendPercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (BlendPercent));
      MoodBlendingTest.NativeFieldInfoPtr_DayNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (DayNight));
      MoodBlendingTest.NativeFieldInfoPtr_AdditionalMood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (AdditionalMood));
      MoodBlendingTest.NativeFieldInfoPtr_AdditionalMoodWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (AdditionalMoodWeight));
      MoodBlendingTest.NativeFieldInfoPtr__Mood1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (_Mood1));
      MoodBlendingTest.NativeFieldInfoPtr__Mood2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (_Mood2));
      MoodBlendingTest.NativeFieldInfoPtr__AdditionalMoodBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (_AdditionalMoodBlend));
      MoodBlendingTest.NativeFieldInfoPtr_BlendStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, nameof (BlendStack));
      MoodBlendingTest.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, 100692626);
      MoodBlendingTest.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, 100692627);
      MoodBlendingTest.NativeMethodInfoPtr_OnBlendMoods_Private_Void_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, 100692628);
      MoodBlendingTest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MoodBlendingTest>.NativeClassPtr, 100692629);
    }

    public MoodBlendingTest(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe MoodSetting Mood1
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_Mood1));
        return pointer == IntPtr.Zero ? (MoodSetting) null : new MoodSetting(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_Mood1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MoodSetting Mood2
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_Mood2));
        return pointer == IntPtr.Zero ? (MoodSetting) null : new MoodSetting(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_Mood2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float BlendPercent
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_BlendPercent));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_BlendPercent)) = value;
      }
    }

    public unsafe float DayNight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_DayNight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_DayNight)) = value;
      }
    }

    public unsafe MoodSetting AdditionalMood
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_AdditionalMood));
        return pointer == IntPtr.Zero ? (MoodSetting) null : new MoodSetting(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_AdditionalMood), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float AdditionalMoodWeight
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_AdditionalMoodWeight));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_AdditionalMoodWeight)) = value;
      }
    }

    public unsafe BlendedMood _Mood1
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr__Mood1));
        return pointer == IntPtr.Zero ? (BlendedMood) null : new BlendedMood(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr__Mood1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlendedMood _Mood2
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr__Mood2));
        return pointer == IntPtr.Zero ? (BlendedMood) null : new BlendedMood(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr__Mood2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe BlendedMood _AdditionalMoodBlend
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr__AdditionalMoodBlend));
        return pointer == IntPtr.Zero ? (BlendedMood) null : new BlendedMood(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr__AdditionalMoodBlend), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool BlendStack
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_BlendStack));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MoodBlendingTest.NativeFieldInfoPtr_BlendStack)) = value;
      }
    }
  }
}
