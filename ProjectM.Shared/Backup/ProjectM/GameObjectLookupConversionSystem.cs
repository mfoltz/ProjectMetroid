// Decompiled with JetBrains decompiler
// Type: ProjectM.GameObjectLookupConversionSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class GameObjectLookupConversionSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GameObjectToConversionEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_DstEntityToGameObject;
    private static readonly System.IntPtr NativeFieldInfoPtr_Terrain;
    private static readonly System.IntPtr NativeFieldInfoPtr_Initialized;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddConversionEntities_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764213, XrefRangeEnd = 764254, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameObjectLookupConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 764301, RefRangeEnd = 764303, XrefRangeStart = 764254, XrefRangeEnd = 764301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddConversionEntities<T>() where T : Component
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameObjectLookupConversionSystem.MethodInfoStoreGeneric_AddConversionEntities_Private_Void_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764303, XrefRangeEnd = 764318, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameObjectLookupConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GameObjectLookupConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), GameObjectLookupConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GameObjectLookupConversionSystem()
    {
      Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (GameObjectLookupConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr);
      GameObjectLookupConversionSystem.NativeFieldInfoPtr_GameObjectToConversionEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr, nameof (GameObjectToConversionEntity));
      GameObjectLookupConversionSystem.NativeFieldInfoPtr_DstEntityToGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr, nameof (DstEntityToGameObject));
      GameObjectLookupConversionSystem.NativeFieldInfoPtr_Terrain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr, nameof (Terrain));
      GameObjectLookupConversionSystem.NativeFieldInfoPtr_Initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr, nameof (Initialized));
      GameObjectLookupConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr, 100667515);
      GameObjectLookupConversionSystem.NativeMethodInfoPtr_AddConversionEntities_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr, 100667516);
      GameObjectLookupConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr, 100667517);
      GameObjectLookupConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr, 100667518);
    }

    public GameObjectLookupConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Dictionary<GameObject, Entity> GameObjectToConversionEntity
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameObjectLookupConversionSystem.NativeFieldInfoPtr_GameObjectToConversionEntity));
        return pointer == System.IntPtr.Zero ? (Dictionary<GameObject, Entity>) null : new Dictionary<GameObject, Entity>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameObjectLookupConversionSystem.NativeFieldInfoPtr_GameObjectToConversionEntity), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<Entity, GameObject> DstEntityToGameObject
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameObjectLookupConversionSystem.NativeFieldInfoPtr_DstEntityToGameObject));
        return pointer == System.IntPtr.Zero ? (Dictionary<Entity, GameObject>) null : new Dictionary<Entity, GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameObjectLookupConversionSystem.NativeFieldInfoPtr_DstEntityToGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject Terrain
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameObjectLookupConversionSystem.NativeFieldInfoPtr_Terrain));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GameObjectLookupConversionSystem.NativeFieldInfoPtr_Terrain), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool Initialized
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameObjectLookupConversionSystem.NativeFieldInfoPtr_Initialized));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GameObjectLookupConversionSystem.NativeFieldInfoPtr_Initialized)) = value;
      }
    }

    [ObfuscatedName("ProjectM.GameObjectLookupConversionSystem/<>c__5`1")]
    [Serializable]
    public sealed class __c__5<T> : Il2CppSystem.Object where T : Component
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__AddConversionEntities_b__5_0_Internal_GameObject_T_0;

      [CallerCount(653)]
      [CachedScanResults(RefRangeStart = 134013, RefRangeEnd = 134666, XrefRangeStart = 134013, XrefRangeEnd = 134666, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__5()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameObjectLookupConversionSystem.__c__5<T>>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(GameObjectLookupConversionSystem.__c__5<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 764211, XrefRangeEnd = 764213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe GameObject _AddConversionEntities_b__5_0(T x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
        System.IntPtr* numPtr2 = numPtr1;
        // ISSUE: variable of a reference type
        T& local1;
        if (!typeof (T).IsValueType)
        {
          // ISSUE: variable of a boxed type
          __Boxed<T> local2 = (object) x;
          // ISSUE: cast to a reference type
          // ISSUE: cast to a reference type
          local1 = local2 is string ? (T&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (T&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
        }
        else
          local1 = ref x;
        *numPtr2 = (System.IntPtr) ref local1;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(GameObjectLookupConversionSystem.__c__5<T>.NativeMethodInfoPtr__AddConversionEntities_b__5_0_Internal_GameObject_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }

      static __c__5()
      {
        // ISSUE: explicit non-virtual call
        // ISSUE: explicit non-virtual call
        Il2CppClassPointerStore<GameObjectLookupConversionSystem.__c__5<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr, "<>c__5`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
        {
          Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
        }))).TypeHandle).value);
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameObjectLookupConversionSystem.__c__5<T>>.NativeClassPtr);
        GameObjectLookupConversionSystem.__c__5<T>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLookupConversionSystem.__c__5<T>>.NativeClassPtr, "<>9");
        GameObjectLookupConversionSystem.__c__5<T>.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameObjectLookupConversionSystem.__c__5<T>>.NativeClassPtr, "<>9__5_0");
        GameObjectLookupConversionSystem.__c__5<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLookupConversionSystem.__c__5<T>>.NativeClassPtr, 100667520);
        GameObjectLookupConversionSystem.__c__5<T>.NativeMethodInfoPtr__AddConversionEntities_b__5_0_Internal_GameObject_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameObjectLookupConversionSystem.__c__5<T>>.NativeClassPtr, 100667521);
      }

      public __c__5(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe GameObjectLookupConversionSystem.__c__5<T> __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameObjectLookupConversionSystem.__c__5<T>.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (GameObjectLookupConversionSystem.__c__5<T>) null : new GameObjectLookupConversionSystem.__c__5<T>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameObjectLookupConversionSystem.__c__5<T>.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<T, GameObject> __9__5_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(GameObjectLookupConversionSystem.__c__5<T>.NativeFieldInfoPtr___9__5_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<T, GameObject>) null : new Il2CppSystem.Func<T, GameObject>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(GameObjectLookupConversionSystem.__c__5<T>.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    private sealed class MethodInfoStoreGeneric_AddConversionEntities_Private_Void_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(GameObjectLookupConversionSystem.NativeMethodInfoPtr_AddConversionEntities_Private_Void_0, Il2CppClassPointerStore<GameObjectLookupConversionSystem>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
