// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.CastOptionsAuthoring
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Behaviours
{
  public class CastOptionsAuthoring : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_State;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastOptionGroups;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Internal_Void_CastOptionsRootAuthoring_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetStateBufferElement_Private_Boolean_DynamicBuffer_1_CastOptionStateBuffer_byref_CastOptionStateBuffer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335773, XrefRangeEnd = 1335779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Convert(
      CastOptionsRootAuthoring unitMappingAuthoring,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) unitMappingAuthoring);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastOptionsAuthoring.NativeMethodInfoPtr_Convert_Internal_Void_CastOptionsRootAuthoring_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335779, XrefRangeEnd = 1335798, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetStateBufferElement(
      DynamicBuffer<CastOptionStateBuffer> buffer,
      out CastOptionStateBuffer result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &buffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastOptionsAuthoring.NativeMethodInfoPtr_TryGetStateBufferElement_Private_Boolean_DynamicBuffer_1_CastOptionStateBuffer_byref_CastOptionStateBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1335798, XrefRangeEnd = 1335804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastOptionsAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastOptionsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastOptionsAuthoring()
    {
      Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (CastOptionsAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr);
      CastOptionsAuthoring.NativeFieldInfoPtr_State = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr, nameof (State));
      CastOptionsAuthoring.NativeFieldInfoPtr_CastOptionGroups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr, nameof (CastOptionGroups));
      CastOptionsAuthoring.NativeMethodInfoPtr_Convert_Internal_Void_CastOptionsRootAuthoring_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr, 100664405);
      CastOptionsAuthoring.NativeMethodInfoPtr_TryGetStateBufferElement_Private_Boolean_DynamicBuffer_1_CastOptionStateBuffer_byref_CastOptionStateBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr, 100664406);
      CastOptionsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr, 100664407);
    }

    public CastOptionsAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GenericEnemyState State
    {
      get
      {
        return *(GenericEnemyState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.NativeFieldInfoPtr_State));
      }
      [param: In] set
      {
        *(GenericEnemyState*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.NativeFieldInfoPtr_State)) = value;
      }
    }

    public unsafe CastOptionsAuthoring.CastOptionGroupArray CastOptionGroups
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.NativeFieldInfoPtr_CastOptionGroups));
        return pointer == System.IntPtr.Zero ? (CastOptionsAuthoring.CastOptionGroupArray) null : new CastOptionsAuthoring.CastOptionGroupArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.NativeFieldInfoPtr_CastOptionGroups), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class SuccessDelay : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_DelayMin;
      private static readonly System.IntPtr NativeFieldInfoPtr_DelayMax;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SuccessDelay()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastOptionsAuthoring.SuccessDelay>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastOptionsAuthoring.SuccessDelay.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SuccessDelay()
      {
        Il2CppClassPointerStore<CastOptionsAuthoring.SuccessDelay>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr, nameof (SuccessDelay));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionsAuthoring.SuccessDelay>.NativeClassPtr);
        CastOptionsAuthoring.SuccessDelay.NativeFieldInfoPtr_DelayMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.SuccessDelay>.NativeClassPtr, nameof (DelayMin));
        CastOptionsAuthoring.SuccessDelay.NativeFieldInfoPtr_DelayMax = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.SuccessDelay>.NativeClassPtr, nameof (DelayMax));
        CastOptionsAuthoring.SuccessDelay.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsAuthoring.SuccessDelay>.NativeClassPtr, 100664408);
      }

      public SuccessDelay(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe float DelayMin
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.SuccessDelay.NativeFieldInfoPtr_DelayMin));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.SuccessDelay.NativeFieldInfoPtr_DelayMin)) = value;
        }
      }

      public unsafe float DelayMax
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.SuccessDelay.NativeFieldInfoPtr_DelayMax));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.SuccessDelay.NativeFieldInfoPtr_DelayMax)) = value;
        }
      }
    }

    [Serializable]
    public class CastOption : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Active;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
      private static readonly System.IntPtr NativeFieldInfoPtr_Probability;
      private static readonly System.IntPtr NativeFieldInfoPtr_AggroFilter;
      private static readonly System.IntPtr NativeFieldInfoPtr_AngleRequirement;
      private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreCooldown;
      private static readonly System.IntPtr NativeFieldInfoPtr_LineOfSightRequirement;
      private static readonly System.IntPtr NativeFieldInfoPtr_InterruptOnTargetDeath;
      private static readonly System.IntPtr NativeFieldInfoPtr_SuccessDelay;
      private static readonly System.IntPtr NativeFieldInfoPtr_Range;
      private static readonly System.IntPtr NativeFieldInfoPtr_Cooldown;
      private static readonly System.IntPtr NativeFieldInfoPtr_TieBreaker;
      private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CastOption()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastOptionsAuthoring.CastOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CastOption()
      {
        Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr, nameof (CastOption));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr);
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (Active));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (Name));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (Ability));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Probability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (Probability));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_AggroFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (AggroFilter));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_AngleRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (AngleRequirement));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_IgnoreCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (IgnoreCooldown));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_LineOfSightRequirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (LineOfSightRequirement));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_InterruptOnTargetDeath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (InterruptOnTargetDeath));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_SuccessDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (SuccessDelay));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (Range));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Cooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (Cooldown));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_TieBreaker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (TieBreaker));
        CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, nameof (Conditional));
        CastOptionsAuthoring.CastOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsAuthoring.CastOption>.NativeClassPtr, 100664409);
      }

      public CastOption(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe bool Active
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Active));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Active)) = value;
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe AbilityGroupComponent Ability
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Ability));
          return pointer == System.IntPtr.Zero ? (AbilityGroupComponent) null : new AbilityGroupComponent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Ability), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe int Probability
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Probability));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Probability)) = value;
        }
      }

      public unsafe CastOptionAggroFilter AggroFilter
      {
        get
        {
          return *(CastOptionAggroFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_AggroFilter));
        }
        [param: In] set
        {
          *(CastOptionAggroFilter*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_AggroFilter)) = value;
        }
      }

      public unsafe CastOptionAngleRequirement AngleRequirement
      {
        get
        {
          return *(CastOptionAngleRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_AngleRequirement));
        }
        [param: In] set
        {
          *(CastOptionAngleRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_AngleRequirement)) = value;
        }
      }

      public unsafe CastOptionIgnoreCooldown IgnoreCooldown
      {
        get
        {
          return *(CastOptionIgnoreCooldown*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_IgnoreCooldown));
        }
        [param: In] set
        {
          *(CastOptionIgnoreCooldown*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_IgnoreCooldown)) = value;
        }
      }

      public unsafe CastOptionLineOfSightRequirement LineOfSightRequirement
      {
        get
        {
          return *(CastOptionLineOfSightRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_LineOfSightRequirement));
        }
        [param: In] set
        {
          *(CastOptionLineOfSightRequirement*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_LineOfSightRequirement)) = value;
        }
      }

      public unsafe bool InterruptOnTargetDeath
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_InterruptOnTargetDeath));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_InterruptOnTargetDeath)) = value;
        }
      }

      public unsafe CastOptionsAuthoring.SuccessDelay SuccessDelay
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_SuccessDelay));
          return pointer == System.IntPtr.Zero ? (CastOptionsAuthoring.SuccessDelay) null : new CastOptionsAuthoring.SuccessDelay(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_SuccessDelay), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe CastOptionRange Range
      {
        get
        {
          return *(CastOptionRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Range));
        }
        [param: In] set
        {
          *(CastOptionRange*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Range)) = value;
        }
      }

      public unsafe CastOptionCooldown_Editor Cooldown
      {
        get
        {
          return *(CastOptionCooldown_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Cooldown));
        }
        [param: In] set
        {
          *(CastOptionCooldown_Editor*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Cooldown)) = value;
        }
      }

      public unsafe CastOptionTieBreaker TieBreaker
      {
        get
        {
          return *(CastOptionTieBreaker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_TieBreaker));
        }
        [param: In] set
        {
          *(CastOptionTieBreaker*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_TieBreaker)) = value;
        }
      }

      public unsafe GameplayConditionGroupData_Editor_Parent Conditional
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Conditional));
          return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOption.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [Serializable]
    public class CastOptionGroup : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Active;
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Conditional;
      private static readonly System.IntPtr NativeFieldInfoPtr_CastOptions;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CastOptionGroup()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroup>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastOptionsAuthoring.CastOptionGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CastOptionGroup()
      {
        Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroup>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr, nameof (CastOptionGroup));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroup>.NativeClassPtr);
        CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroup>.NativeClassPtr, nameof (Active));
        CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroup>.NativeClassPtr, nameof (Name));
        CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroup>.NativeClassPtr, nameof (Conditional));
        CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_CastOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroup>.NativeClassPtr, nameof (CastOptions));
        CastOptionsAuthoring.CastOptionGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroup>.NativeClassPtr, 100664410);
      }

      public CastOptionGroup(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe bool Active
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_Active));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_Active)) = value;
        }
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe GameplayConditionGroupData_Editor_Parent Conditional
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_Conditional));
          return pointer == System.IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<CastOptionsAuthoring.CastOption> CastOptions
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_CastOptions));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<CastOptionsAuthoring.CastOption>) null : new Il2CppReferenceArray<CastOptionsAuthoring.CastOption>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CastOptionsAuthoring.CastOptionGroup.NativeFieldInfoPtr_CastOptions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [Serializable]
    public class CastOptionGroupArray : ReorderableArray<CastOptionsAuthoring.CastOptionGroup>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1335772, RefRangeEnd = 1335773, XrefRangeStart = 1335769, XrefRangeEnd = 1335772, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe CastOptionGroupArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroupArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CastOptionsAuthoring.CastOptionGroupArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static CastOptionGroupArray()
      {
        Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroupArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CastOptionsAuthoring>.NativeClassPtr, nameof (CastOptionGroupArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroupArray>.NativeClassPtr);
        CastOptionsAuthoring.CastOptionGroupArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastOptionsAuthoring.CastOptionGroupArray>.NativeClassPtr, 100664411);
      }

      public CastOptionGroupArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
