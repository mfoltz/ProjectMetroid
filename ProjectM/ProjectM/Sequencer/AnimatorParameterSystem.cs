// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.AnimatorParameterSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Hybrid;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class AnimatorParameterSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Entries;
    private static readonly System.IntPtr NativeFieldInfoPtr__OriginalParameterValues;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Entries_Public_get_NativeList_1_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetParameter_Private_Void_Entry_HybridModelAnimationComponent_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimatorParameter_Private_Void_Entry_Animator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetAnimatorParameter_Private_Void_Entry_Il2CppReferenceArray_1_Animator_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAnimatorParameter_Private_Void_Animator_byref_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DebugData_Private_String_Entry_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public unsafe NativeList<AnimatorParameterSystem.Entry> Entries
    {
      [CallerCount(54), CachedScanResults(RefRangeStart = 73358, RefRangeEnd = 73412, XrefRangeStart = 73358, XrefRangeEnd = 73412, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.NativeMethodInfoPtr_get_Entries_Public_get_NativeList_1_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NativeList<AnimatorParameterSystem.Entry>*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100607, XrefRangeEnd = 1100612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100612, XrefRangeEnd = 1100617, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100617, XrefRangeEnd = 1100710, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1100749, RefRangeEnd = 1100751, XrefRangeStart = 1100710, XrefRangeEnd = 1100749, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetParameter(
      AnimatorParameterSystem.Entry entry,
      HybridModelAnimationComponent animationComponent)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entry;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animationComponent);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.NativeMethodInfoPtr_SetParameter_Private_Void_Entry_HybridModelAnimationComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100751, XrefRangeEnd = 1100753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAnimatorParameter(AnimatorParameterSystem.Entry entry, Animator animator)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entry;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.NativeMethodInfoPtr_SetAnimatorParameter_Private_Void_Entry_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1100770, RefRangeEnd = 1100771, XrefRangeStart = 1100753, XrefRangeEnd = 1100770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetAnimatorParameter(
      AnimatorParameterSystem.Entry entry,
      Il2CppReferenceArray<Animator> animators)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entry;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animators);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.NativeMethodInfoPtr_SetAnimatorParameter_Private_Void_Entry_Il2CppReferenceArray_1_Animator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100771, XrefRangeEnd = 1100773, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetAnimatorParameter(
      Animator animator,
      ref AnimatorParameterSystem.Entry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) animator);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref entry;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.NativeMethodInfoPtr_GetAnimatorParameter_Private_Void_Animator_byref_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100773, XrefRangeEnd = 1100802, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string DebugData(AnimatorParameterSystem.Entry entry)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entry;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.NativeMethodInfoPtr_DebugData_Private_String_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AnimatorParameterSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AnimatorParameterSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AnimatorParameterSystem()
    {
      Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (AnimatorParameterSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr);
      AnimatorParameterSystem.NativeFieldInfoPtr__Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, nameof (_Entries));
      AnimatorParameterSystem.NativeFieldInfoPtr__OriginalParameterValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, nameof (_OriginalParameterValues));
      AnimatorParameterSystem.NativeMethodInfoPtr_get_Entries_Public_get_NativeList_1_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687327);
      AnimatorParameterSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687328);
      AnimatorParameterSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687329);
      AnimatorParameterSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687330);
      AnimatorParameterSystem.NativeMethodInfoPtr_SetParameter_Private_Void_Entry_HybridModelAnimationComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687331);
      AnimatorParameterSystem.NativeMethodInfoPtr_SetAnimatorParameter_Private_Void_Entry_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687332);
      AnimatorParameterSystem.NativeMethodInfoPtr_SetAnimatorParameter_Private_Void_Entry_Il2CppReferenceArray_1_Animator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687333);
      AnimatorParameterSystem.NativeMethodInfoPtr_GetAnimatorParameter_Private_Void_Animator_byref_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687334);
      AnimatorParameterSystem.NativeMethodInfoPtr_DebugData_Private_String_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687335);
      AnimatorParameterSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687336);
      AnimatorParameterSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, 100687337);
    }

    public AnimatorParameterSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe NativeList<AnimatorParameterSystem.Entry> _Entries
    {
      get
      {
        return *(NativeList<AnimatorParameterSystem.Entry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterSystem.NativeFieldInfoPtr__Entries));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterSystem.NativeFieldInfoPtr__Entries), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<AnimatorParameterSystem.Entry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe NativeList<AnimatorParameterSystem.Entry> _OriginalParameterValues
    {
      get
      {
        return *(NativeList<AnimatorParameterSystem.Entry>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterSystem.NativeFieldInfoPtr__OriginalParameterValues));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AnimatorParameterSystem.NativeFieldInfoPtr__OriginalParameterValues), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NativeList<AnimatorParameterSystem.Entry>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Entry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParameterName;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParameterType;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParameterFloat;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParameterInt;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParameterBool;
      private static readonly System.IntPtr NativeFieldInfoPtr_SetAnimationListeners;
      private static readonly System.IntPtr NativeFieldInfoPtr_RestoreOnFinish;
      private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Entry_0;
      [FieldOffset(0)]
      public Entity Entity;
      [FieldOffset(8)]
      public int Importance;
      [FieldOffset(12)]
      public FixedString64 ParameterName;
      [FieldOffset(76)]
      public AnimatorParameterTypeEnum ParameterType;
      [FieldOffset(80)]
      public float ParameterFloat;
      [FieldOffset(84)]
      public int ParameterInt;
      [FieldOffset(88)]
      public bool ParameterBool;
      [FieldOffset(89)]
      public bool SetAnimationListeners;
      [FieldOffset(90)]
      public bool RestoreOnFinish;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100563, XrefRangeEnd = 1100606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe string ToString()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.Entry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1100606, XrefRangeEnd = 1100607, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(AnimatorParameterSystem.Entry other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.Entry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Entry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Entry()
      {
        Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, nameof (Entry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr);
        AnimatorParameterSystem.Entry.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, nameof (Entity));
        AnimatorParameterSystem.Entry.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, nameof (Importance));
        AnimatorParameterSystem.Entry.NativeFieldInfoPtr_ParameterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, nameof (ParameterName));
        AnimatorParameterSystem.Entry.NativeFieldInfoPtr_ParameterType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, nameof (ParameterType));
        AnimatorParameterSystem.Entry.NativeFieldInfoPtr_ParameterFloat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, nameof (ParameterFloat));
        AnimatorParameterSystem.Entry.NativeFieldInfoPtr_ParameterInt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, nameof (ParameterInt));
        AnimatorParameterSystem.Entry.NativeFieldInfoPtr_ParameterBool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, nameof (ParameterBool));
        AnimatorParameterSystem.Entry.NativeFieldInfoPtr_SetAnimationListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, nameof (SetAnimationListeners));
        AnimatorParameterSystem.Entry.NativeFieldInfoPtr_RestoreOnFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, nameof (RestoreOnFinish));
        AnimatorParameterSystem.Entry.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, 100687338);
        AnimatorParameterSystem.Entry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, 100687339);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AnimatorParameterSystem.Entry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Sequencer.AnimatorParameterSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__8_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__SetParameter_b__8_0_Internal_Animator_HybridModelAnimationListenerComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnimatorParameterSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe Animator _SetParameter_b__8_0(HybridModelAnimationListenerComponent x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AnimatorParameterSystem.__c.NativeMethodInfoPtr__SetParameter_b__8_0_Internal_Animator_HybridModelAnimationListenerComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Animator) null : new Animator(pointer);
      }

      static __c()
      {
        Il2CppClassPointerStore<AnimatorParameterSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AnimatorParameterSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnimatorParameterSystem.__c>.NativeClassPtr);
        AnimatorParameterSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.__c>.NativeClassPtr, "<>9");
        AnimatorParameterSystem.__c.NativeFieldInfoPtr___9__8_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AnimatorParameterSystem.__c>.NativeClassPtr, "<>9__8_0");
        AnimatorParameterSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem.__c>.NativeClassPtr, 100687341);
        AnimatorParameterSystem.__c.NativeMethodInfoPtr__SetParameter_b__8_0_Internal_Animator_HybridModelAnimationListenerComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnimatorParameterSystem.__c>.NativeClassPtr, 100687342);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe AnimatorParameterSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AnimatorParameterSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (AnimatorParameterSystem.__c) null : new AnimatorParameterSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AnimatorParameterSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<HybridModelAnimationListenerComponent, Animator> __9__8_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(AnimatorParameterSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<HybridModelAnimationListenerComponent, Animator>) null : new Il2CppSystem.Func<HybridModelAnimationListenerComponent, Animator>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(AnimatorParameterSystem.__c.NativeFieldInfoPtr___9__8_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
