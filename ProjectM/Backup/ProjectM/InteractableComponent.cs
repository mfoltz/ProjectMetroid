// Decompiled with JetBrains decompiler
// Type: ProjectM.InteractableComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class InteractableComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractAbilities;
    private static readonly System.IntPtr NativeFieldInfoPtr_Importance;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseInteractAbilityName;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreLineOfSight;
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreBlockInteract;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockBuildingMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockBuildingDisassemble;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractionActiveSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTargetSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_InteractEndSequence;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000969, XrefRangeEnd = 1001041, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractableComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001041, XrefRangeEnd = 1001061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), InteractableComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001061, XrefRangeEnd = 1001062, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InteractableComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractableComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InteractableComponent()
    {
      Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InteractableComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr);
      InteractableComponent.NativeFieldInfoPtr_InteractAbilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (InteractAbilities));
      InteractableComponent.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (Importance));
      InteractableComponent.NativeFieldInfoPtr_UseInteractAbilityName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (UseInteractAbilityName));
      InteractableComponent.NativeFieldInfoPtr_IgnoreLineOfSight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (IgnoreLineOfSight));
      InteractableComponent.NativeFieldInfoPtr_IgnoreBlockInteract = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (IgnoreBlockInteract));
      InteractableComponent.NativeFieldInfoPtr_BlockBuildingMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (BlockBuildingMovement));
      InteractableComponent.NativeFieldInfoPtr_BlockBuildingDisassemble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (BlockBuildingDisassemble));
      InteractableComponent.NativeFieldInfoPtr_InteractionActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (InteractionActiveSequence));
      InteractableComponent.NativeFieldInfoPtr_CurrentTargetSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (CurrentTargetSequence));
      InteractableComponent.NativeFieldInfoPtr_InteractEndSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (InteractEndSequence));
      InteractableComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, 100677478);
      InteractableComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, 100677479);
      InteractableComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, 100677480);
    }

    public InteractableComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe InteractableComponent.InteractableAbilitiesArray InteractAbilities
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_InteractAbilities));
        return pointer == System.IntPtr.Zero ? (InteractableComponent.InteractableAbilitiesArray) null : new InteractableComponent.InteractableAbilitiesArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_InteractAbilities), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int Importance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_Importance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_Importance)) = value;
      }
    }

    public unsafe bool UseInteractAbilityName
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_UseInteractAbilityName));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_UseInteractAbilityName)) = value;
      }
    }

    public unsafe bool IgnoreLineOfSight
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_IgnoreLineOfSight));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_IgnoreLineOfSight)) = value;
      }
    }

    public unsafe bool IgnoreBlockInteract
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_IgnoreBlockInteract));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_IgnoreBlockInteract)) = value;
      }
    }

    public unsafe bool BlockBuildingMovement
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_BlockBuildingMovement));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_BlockBuildingMovement)) = value;
      }
    }

    public unsafe bool BlockBuildingDisassemble
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_BlockBuildingDisassemble));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_BlockBuildingDisassemble)) = value;
      }
    }

    public unsafe SequenceField InteractionActiveSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_InteractionActiveSequence));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_InteractionActiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField CurrentTargetSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_CurrentTargetSequence));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_CurrentTargetSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SequenceField InteractEndSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_InteractEndSequence));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InteractableComponent.NativeFieldInfoPtr_InteractEndSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class InteractableAbilitiesArray : ReorderableArray<InteractAbility_Editor>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000966, XrefRangeEnd = 1000969, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe InteractableAbilitiesArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableComponent.InteractableAbilitiesArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractableComponent.InteractableAbilitiesArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static InteractableAbilitiesArray()
      {
        Il2CppClassPointerStore<InteractableComponent.InteractableAbilitiesArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, nameof (InteractableAbilitiesArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableComponent.InteractableAbilitiesArray>.NativeClassPtr);
        InteractableComponent.InteractableAbilitiesArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableComponent.InteractableAbilitiesArray>.NativeClassPtr, 100677481);
      }

      public InteractableAbilitiesArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }

    [ObfuscatedName("ProjectM.InteractableComponent/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__11_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__11_0_Internal_Int32_InteractAbility_Editor_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractableComponent.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(InteractableComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe int _Convert_b__11_0(InteractAbility_Editor x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractableComponent.__c.NativeMethodInfoPtr__Convert_b__11_0_Internal_Int32_InteractAbility_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<InteractableComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractableComponent>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractableComponent.__c>.NativeClassPtr);
        InteractableComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent.__c>.NativeClassPtr, "<>9");
        InteractableComponent.__c.NativeFieldInfoPtr___9__11_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractableComponent.__c>.NativeClassPtr, "<>9__11_0");
        InteractableComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableComponent.__c>.NativeClassPtr, 100677483);
        InteractableComponent.__c.NativeMethodInfoPtr__Convert_b__11_0_Internal_Int32_InteractAbility_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractableComponent.__c>.NativeClassPtr, 100677484);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe InteractableComponent.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractableComponent.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (InteractableComponent.__c) null : new InteractableComponent.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractableComponent.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<InteractAbility_Editor, int> __9__11_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(InteractableComponent.__c.NativeFieldInfoPtr___9__11_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<InteractAbility_Editor, int>) null : new Il2CppSystem.Func<InteractAbility_Editor, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(InteractableComponent.__c.NativeFieldInfoPtr___9__11_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
