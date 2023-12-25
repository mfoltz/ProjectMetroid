// Decompiled with JetBrains decompiler
// Type: ProjectM.Physics.PhysicsRubbleAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Physics.Authoring;
using UnityEngine;

#nullable disable
namespace ProjectM.Physics
{
  public class PhysicsRubbleAuthoring : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DespawnSequence;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_DissolveDuration;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109759, XrefRangeEnd = 1109851, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(PhysicsRubbleAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109851, XrefRangeEnd = 1109852, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PhysicsRubbleAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsRubbleAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PhysicsRubbleAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PhysicsRubbleAuthoring()
    {
      Il2CppClassPointerStore<PhysicsRubbleAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Physics", nameof (PhysicsRubbleAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsRubbleAuthoring>.NativeClassPtr);
      PhysicsRubbleAuthoring.NativeFieldInfoPtr_DespawnSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubbleAuthoring>.NativeClassPtr, nameof (DespawnSequence));
      PhysicsRubbleAuthoring.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubbleAuthoring>.NativeClassPtr, nameof (Duration));
      PhysicsRubbleAuthoring.NativeFieldInfoPtr_DissolveDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubbleAuthoring>.NativeClassPtr, nameof (DissolveDuration));
      PhysicsRubbleAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRubbleAuthoring>.NativeClassPtr, 100687844);
      PhysicsRubbleAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRubbleAuthoring>.NativeClassPtr, 100687845);
    }

    public PhysicsRubbleAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe SequenceField DespawnSequence
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhysicsRubbleAuthoring.NativeFieldInfoPtr_DespawnSequence));
        return pointer == System.IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PhysicsRubbleAuthoring.NativeFieldInfoPtr_DespawnSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhysicsRubbleAuthoring.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhysicsRubbleAuthoring.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe float DissolveDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhysicsRubbleAuthoring.NativeFieldInfoPtr_DissolveDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PhysicsRubbleAuthoring.NativeFieldInfoPtr_DissolveDuration)) = value;
      }
    }

    [ObfuscatedName("ProjectM.Physics.PhysicsRubbleAuthoring/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__3_0_Internal_Transform_Rigidbody_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__3_1_Internal_Transform_PhysicsBodyAuthoring_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhysicsRubbleAuthoring.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PhysicsRubbleAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1109757, XrefRangeEnd = 1109759, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Transform _Convert_b__3_0(Rigidbody x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PhysicsRubbleAuthoring.__c.NativeMethodInfoPtr__Convert_b__3_0_Internal_Transform_Rigidbody_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Transform _Convert_b__3_1(PhysicsBodyAuthoring x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PhysicsRubbleAuthoring.__c.NativeMethodInfoPtr__Convert_b__3_1_Internal_Transform_PhysicsBodyAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }

      static __c()
      {
        Il2CppClassPointerStore<PhysicsRubbleAuthoring.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhysicsRubbleAuthoring>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhysicsRubbleAuthoring.__c>.NativeClassPtr);
        PhysicsRubbleAuthoring.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubbleAuthoring.__c>.NativeClassPtr, "<>9");
        PhysicsRubbleAuthoring.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubbleAuthoring.__c>.NativeClassPtr, "<>9__3_0");
        PhysicsRubbleAuthoring.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhysicsRubbleAuthoring.__c>.NativeClassPtr, "<>9__3_1");
        PhysicsRubbleAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRubbleAuthoring.__c>.NativeClassPtr, 100687847);
        PhysicsRubbleAuthoring.__c.NativeMethodInfoPtr__Convert_b__3_0_Internal_Transform_Rigidbody_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRubbleAuthoring.__c>.NativeClassPtr, 100687848);
        PhysicsRubbleAuthoring.__c.NativeMethodInfoPtr__Convert_b__3_1_Internal_Transform_PhysicsBodyAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhysicsRubbleAuthoring.__c>.NativeClassPtr, 100687849);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe PhysicsRubbleAuthoring.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PhysicsRubbleAuthoring.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (PhysicsRubbleAuthoring.__c) null : new PhysicsRubbleAuthoring.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PhysicsRubbleAuthoring.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Rigidbody, Transform> __9__3_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PhysicsRubbleAuthoring.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Rigidbody, Transform>) null : new Il2CppSystem.Func<Rigidbody, Transform>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PhysicsRubbleAuthoring.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<PhysicsBodyAuthoring, Transform> __9__3_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(PhysicsRubbleAuthoring.__c.NativeFieldInfoPtr___9__3_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<PhysicsBodyAuthoring, Transform>) null : new Il2CppSystem.Func<PhysicsBodyAuthoring, Transform>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(PhysicsRubbleAuthoring.__c.NativeFieldInfoPtr___9__3_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
