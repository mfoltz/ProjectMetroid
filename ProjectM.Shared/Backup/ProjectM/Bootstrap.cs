// Decompiled with JetBrains decompiler
// Type: ProjectM.Bootstrap
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class Bootstrap : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultWorldName;
    private static readonly System.IntPtr NativeFieldInfoPtr_EditorWorldName;
    private static readonly System.IntPtr NativeFieldInfoPtr_RecommendedRAM;
    private static readonly System.IntPtr NativeMethodInfoPtr_Unity_Entities_ICustomBootstrap_Initialize_Private_Virtual_Final_New_Boolean_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetAllSystems_Public_Static_IReadOnlyList_1_Type_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FindWorldType_Private_WorldType_World_IEnumerable_1_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateMemoryAndSetMemorySettings_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ChangeGraphicsPreset_Private_Void_PresetMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TurnOffFSR_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720250, XrefRangeEnd = 720410, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Unity_Entities_ICustomBootstrap_Initialize(string defaultWorldName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(defaultWorldName);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Bootstrap.NativeMethodInfoPtr_Unity_Entities_ICustomBootstrap_Initialize_Private_Virtual_Final_New_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 720414, RefRangeEnd = 720416, XrefRangeStart = 720410, XrefRangeEnd = 720414, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe IReadOnlyList<Il2CppSystem.Type> GetAllSystems(bool requireExecuteAlways)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &requireExecuteAlways;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Bootstrap.NativeMethodInfoPtr_GetAllSystems_Public_Static_IReadOnlyList_1_Type_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (IReadOnlyList<Il2CppSystem.Type>) null : new IReadOnlyList<Il2CppSystem.Type>(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720450, RefRangeEnd = 720451, XrefRangeStart = 720416, XrefRangeEnd = 720450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldType FindWorldType(World world, IEnumerable<Il2CppSystem.Type> systems)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systems);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Bootstrap.NativeMethodInfoPtr_FindWorldType_Private_WorldType_World_IEnumerable_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(WorldType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720451, XrefRangeEnd = 720468, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void EvaluateMemoryAndSetMemorySettings()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Bootstrap.NativeMethodInfoPtr_EvaluateMemoryAndSetMemorySettings_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 720479, RefRangeEnd = 720482, XrefRangeStart = 720468, XrefRangeEnd = 720479, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ChangeGraphicsPreset(PresetMode newMode)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &newMode;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Bootstrap.NativeMethodInfoPtr_ChangeGraphicsPreset_Private_Void_PresetMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720482, XrefRangeEnd = 720493, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TurnOffFSR()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Bootstrap.NativeMethodInfoPtr_TurnOffFSR_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 720500, RefRangeEnd = 720501, XrefRangeStart = 720493, XrefRangeEnd = 720500, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Bootstrap()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Bootstrap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Bootstrap()
    {
      Il2CppClassPointerStore<Bootstrap>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Bootstrap));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr);
      Bootstrap.NativeFieldInfoPtr_DefaultWorldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, nameof (DefaultWorldName));
      Bootstrap.NativeFieldInfoPtr_EditorWorldName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, nameof (EditorWorldName));
      Bootstrap.NativeFieldInfoPtr_RecommendedRAM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, nameof (RecommendedRAM));
      Bootstrap.NativeMethodInfoPtr_Unity_Entities_ICustomBootstrap_Initialize_Private_Virtual_Final_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, 100663664);
      Bootstrap.NativeMethodInfoPtr_GetAllSystems_Public_Static_IReadOnlyList_1_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, 100663665);
      Bootstrap.NativeMethodInfoPtr_FindWorldType_Private_WorldType_World_IEnumerable_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, 100663666);
      Bootstrap.NativeMethodInfoPtr_EvaluateMemoryAndSetMemorySettings_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, 100663667);
      Bootstrap.NativeMethodInfoPtr_ChangeGraphicsPreset_Private_Void_PresetMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, 100663668);
      Bootstrap.NativeMethodInfoPtr_TurnOffFSR_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, 100663669);
      Bootstrap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, 100663670);
    }

    public Bootstrap(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string DefaultWorldName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bootstrap.NativeFieldInfoPtr_DefaultWorldName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Bootstrap.NativeFieldInfoPtr_DefaultWorldName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string EditorWorldName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Bootstrap.NativeFieldInfoPtr_EditorWorldName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Bootstrap.NativeFieldInfoPtr_EditorWorldName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe int RecommendedRAM
    {
      get
      {
        int recommendedRam;
        IL2CPP.il2cpp_field_static_get_value(Bootstrap.NativeFieldInfoPtr_RecommendedRAM, (void*) &recommendedRam);
        return recommendedRam;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(Bootstrap.NativeFieldInfoPtr_RecommendedRAM, (void*) &value);
      }
    }

    [ObfuscatedName("ProjectM.Bootstrap/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__4_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__FindWorldType_b__4_0_Internal_Boolean_Type_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Bootstrap.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Bootstrap.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720246, XrefRangeEnd = 720250, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _FindWorldType_b__4_0(Il2CppSystem.Type x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(Bootstrap.__c.NativeMethodInfoPtr__FindWorldType_b__4_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<Bootstrap.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Bootstrap>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Bootstrap.__c>.NativeClassPtr);
        Bootstrap.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstrap.__c>.NativeClassPtr, "<>9");
        Bootstrap.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Bootstrap.__c>.NativeClassPtr, "<>9__4_0");
        Bootstrap.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstrap.__c>.NativeClassPtr, 100663672);
        Bootstrap.__c.NativeMethodInfoPtr__FindWorldType_b__4_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Bootstrap.__c>.NativeClassPtr, 100663673);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe Bootstrap.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Bootstrap.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Bootstrap.__c) null : new Bootstrap.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Bootstrap.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Il2CppSystem.Type, bool> __9__4_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(Bootstrap.__c.NativeFieldInfoPtr___9__4_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Il2CppSystem.Type, bool>) null : new Il2CppSystem.Func<Il2CppSystem.Type, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(Bootstrap.__c.NativeFieldInfoPtr___9__4_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
