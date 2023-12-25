// Decompiled with JetBrains decompiler
// Type: ProjectM.SpawnBuffsAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class SpawnBuffsAuthoring : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Values;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034685, XrefRangeEnd = 1034747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(SpawnBuffsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SpawnBuffsAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnBuffsAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SpawnBuffsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SpawnBuffsAuthoring()
    {
      Il2CppClassPointerStore<SpawnBuffsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpawnBuffsAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnBuffsAuthoring>.NativeClassPtr);
      SpawnBuffsAuthoring.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffsAuthoring>.NativeClassPtr, nameof (Values));
      SpawnBuffsAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnBuffsAuthoring>.NativeClassPtr, 100680890);
      SpawnBuffsAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnBuffsAuthoring>.NativeClassPtr, 100680891);
    }

    public SpawnBuffsAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Il2CppReferenceArray<SpawnBuffsAuthoring.SpawnBuffElement_Editor> Values
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.NativeFieldInfoPtr_Values));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpawnBuffsAuthoring.SpawnBuffElement_Editor>) null : new Il2CppReferenceArray<SpawnBuffsAuthoring.SpawnBuffElement_Editor>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.NativeFieldInfoPtr_Values), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class SpawnBuffElement_Editor : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Kind;
      private static readonly System.IntPtr NativeFieldInfoPtr_Buffs;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnBuffElement_Editor()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnBuffsAuthoring.SpawnBuffElement_Editor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static SpawnBuffElement_Editor()
      {
        Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnBuffsAuthoring>.NativeClassPtr, nameof (SpawnBuffElement_Editor));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor>.NativeClassPtr);
        SpawnBuffsAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor>.NativeClassPtr, nameof (Kind));
        SpawnBuffsAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_Buffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor>.NativeClassPtr, nameof (Buffs));
        SpawnBuffsAuthoring.SpawnBuffElement_Editor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor>.NativeClassPtr, 100680892);
      }

      public SpawnBuffElement_Editor(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe SpawnBuffKind Kind
      {
        get
        {
          return *(SpawnBuffKind*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_Kind));
        }
        [param: In] set
        {
          *(SpawnBuffKind*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_Kind)) = value;
        }
      }

      public unsafe Il2CppReferenceArray<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry> Buffs
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_Buffs));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>) null : new Il2CppReferenceArray<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.SpawnBuffElement_Editor.NativeFieldInfoPtr_Buffs), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      [Serializable]
      public class BuffEntry : Il2CppSystem.Object
      {
        private static readonly System.IntPtr NativeFieldInfoPtr_Buff;
        private static readonly System.IntPtr NativeFieldInfoPtr_Weight;
        private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

        [CallerCount(3875)]
        [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
        public unsafe BuffEntry()
          : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>.NativeClassPtr))
        {
          System.IntPtr* numPtr = (System.IntPtr*) null;
          System.IntPtr exc;
          IL2CPP.il2cpp_runtime_invoke(SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
        }

        static BuffEntry()
        {
          Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor>.NativeClassPtr, nameof (BuffEntry));
          IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>.NativeClassPtr);
          SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry.NativeFieldInfoPtr_Buff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>.NativeClassPtr, nameof (Buff));
          SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry.NativeFieldInfoPtr_Weight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>.NativeClassPtr, nameof (Weight));
          SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>.NativeClassPtr, 100680893);
        }

        public BuffEntry(System.IntPtr pointer)
          : base(pointer)
        {
        }

        public unsafe WeakAssetReference<BuffComponent> Buff
        {
          get
          {
            System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry.NativeFieldInfoPtr_Buff));
            return pointer == System.IntPtr.Zero ? (WeakAssetReference<BuffComponent>) null : new WeakAssetReference<BuffComponent>(pointer);
          }
          [param: In] set
          {
            System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
            IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry.NativeFieldInfoPtr_Buff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
          }
        }

        public unsafe float Weight
        {
          get
          {
            return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry.NativeFieldInfoPtr_Weight));
          }
          [param: In] set
          {
            *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry.NativeFieldInfoPtr_Weight)) = value;
          }
        }
      }
    }

    [ObfuscatedName("ProjectM.SpawnBuffsAuthoring/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__2_0_Internal_IEnumerable_1_BuffEntry_SpawnBuffElement_Editor_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__2_1_Internal_SpawnBuffElement_SpawnBuffElement_Editor_BuffEntry_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpawnBuffsAuthoring.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SpawnBuffsAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe IEnumerable<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry> _Convert_b__2_0(
        SpawnBuffsAuthoring.SpawnBuffElement_Editor value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnBuffsAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_0_Internal_IEnumerable_1_BuffEntry_SpawnBuffElement_Editor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>) null : new IEnumerable<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1034684, XrefRangeEnd = 1034685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe SpawnBuffElement _Convert_b__2_1(
        SpawnBuffsAuthoring.SpawnBuffElement_Editor value,
        SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry buffEntry)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) buffEntry);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpawnBuffsAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_1_Internal_SpawnBuffElement_SpawnBuffElement_Editor_BuffEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(SpawnBuffElement*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<SpawnBuffsAuthoring.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SpawnBuffsAuthoring>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpawnBuffsAuthoring.__c>.NativeClassPtr);
        SpawnBuffsAuthoring.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffsAuthoring.__c>.NativeClassPtr, "<>9");
        SpawnBuffsAuthoring.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffsAuthoring.__c>.NativeClassPtr, "<>9__2_0");
        SpawnBuffsAuthoring.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpawnBuffsAuthoring.__c>.NativeClassPtr, "<>9__2_1");
        SpawnBuffsAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnBuffsAuthoring.__c>.NativeClassPtr, 100680895);
        SpawnBuffsAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_0_Internal_IEnumerable_1_BuffEntry_SpawnBuffElement_Editor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnBuffsAuthoring.__c>.NativeClassPtr, 100680896);
        SpawnBuffsAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_1_Internal_SpawnBuffElement_SpawnBuffElement_Editor_BuffEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpawnBuffsAuthoring.__c>.NativeClassPtr, 100680897);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe SpawnBuffsAuthoring.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnBuffsAuthoring.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (SpawnBuffsAuthoring.__c) null : new SpawnBuffsAuthoring.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnBuffsAuthoring.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SpawnBuffsAuthoring.SpawnBuffElement_Editor, IEnumerable<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>> __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnBuffsAuthoring.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SpawnBuffsAuthoring.SpawnBuffElement_Editor, IEnumerable<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>>) null : new Il2CppSystem.Func<SpawnBuffsAuthoring.SpawnBuffElement_Editor, IEnumerable<SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnBuffsAuthoring.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<SpawnBuffsAuthoring.SpawnBuffElement_Editor, SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry, SpawnBuffElement> __9__2_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SpawnBuffsAuthoring.__c.NativeFieldInfoPtr___9__2_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<SpawnBuffsAuthoring.SpawnBuffElement_Editor, SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry, SpawnBuffElement>) null : new Il2CppSystem.Func<SpawnBuffsAuthoring.SpawnBuffElement_Editor, SpawnBuffsAuthoring.SpawnBuffElement_Editor.BuffEntry, SpawnBuffElement>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SpawnBuffsAuthoring.__c.NativeFieldInfoPtr___9__2_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
