// Decompiled with JetBrains decompiler
// Type: ProjectM.TrackComponentChangesSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class TrackComponentChangesSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__TrackingEnabled;
    private static readonly System.IntPtr NativeFieldInfoPtr__LastRunSystemVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr__ComponentToTrack;
    private static readonly System.IntPtr NativeMethodInfoPtr_TrackComponentType_Public_Void_Type_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTracking_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1653143, XrefRangeEnd = 1653150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrackComponentType(Il2CppSystem.Type type)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrackComponentChangesSystem.NativeMethodInfoPtr_TrackComponentType_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1653150, XrefRangeEnd = 1653151, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RemoveTracking()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrackComponentChangesSystem.NativeMethodInfoPtr_RemoveTracking_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1653151, XrefRangeEnd = 1653269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrackComponentChangesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrackComponentChangesSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrackComponentChangesSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TrackComponentChangesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TrackComponentChangesSystem()
    {
      Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (TrackComponentChangesSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr);
      TrackComponentChangesSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, nameof (_Query));
      TrackComponentChangesSystem.NativeFieldInfoPtr__TrackingEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, nameof (_TrackingEnabled));
      TrackComponentChangesSystem.NativeFieldInfoPtr__LastRunSystemVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, nameof (_LastRunSystemVersion));
      TrackComponentChangesSystem.NativeFieldInfoPtr__ComponentToTrack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, nameof (_ComponentToTrack));
      TrackComponentChangesSystem.NativeMethodInfoPtr_TrackComponentType_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, 100664063);
      TrackComponentChangesSystem.NativeMethodInfoPtr_RemoveTracking_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, 100664064);
      TrackComponentChangesSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, 100664065);
      TrackComponentChangesSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, 100664066);
      TrackComponentChangesSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, 100664067);
    }

    public TrackComponentChangesSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe bool _TrackingEnabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.NativeFieldInfoPtr__TrackingEnabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.NativeFieldInfoPtr__TrackingEnabled)) = value;
      }
    }

    public unsafe uint _LastRunSystemVersion
    {
      get
      {
        return *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.NativeFieldInfoPtr__LastRunSystemVersion));
      }
      [param: In] set
      {
        *(uint*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.NativeFieldInfoPtr__LastRunSystemVersion)) = value;
      }
    }

    public unsafe Il2CppSystem.Type _ComponentToTrack
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.NativeFieldInfoPtr__ComponentToTrack));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.NativeFieldInfoPtr__ComponentToTrack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class Change : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SystemName;
      private static readonly System.IntPtr NativeFieldInfoPtr_ChunksChanged;
      private static readonly System.IntPtr NativeFieldInfoPtr_EntitiesChanged;

      static Change()
      {
        Il2CppClassPointerStore<TrackComponentChangesSystem.Change>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, nameof (Change));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackComponentChangesSystem.Change>.NativeClassPtr);
        TrackComponentChangesSystem.Change.NativeFieldInfoPtr_SystemName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackComponentChangesSystem.Change>.NativeClassPtr, nameof (SystemName));
        TrackComponentChangesSystem.Change.NativeFieldInfoPtr_ChunksChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackComponentChangesSystem.Change>.NativeClassPtr, nameof (ChunksChanged));
        TrackComponentChangesSystem.Change.NativeFieldInfoPtr_EntitiesChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackComponentChangesSystem.Change>.NativeClassPtr, nameof (EntitiesChanged));
      }

      public Change(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public Change()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TrackComponentChangesSystem.Change>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrackComponentChangesSystem.Change>.NativeClassPtr, data));
      }

      public unsafe string SystemName
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.Change.NativeFieldInfoPtr_SystemName)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.Change.NativeFieldInfoPtr_SystemName), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe int ChunksChanged
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.Change.NativeFieldInfoPtr_ChunksChanged));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.Change.NativeFieldInfoPtr_ChunksChanged)) = value;
        }
      }

      public unsafe int EntitiesChanged
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.Change.NativeFieldInfoPtr_EntitiesChanged));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackComponentChangesSystem.Change.NativeFieldInfoPtr_EntitiesChanged)) = value;
        }
      }
    }

    [ObfuscatedName("ProjectM.TrackComponentChangesSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__7_0_Internal_Int32_Change_Change_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackComponentChangesSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrackComponentChangesSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1653141, XrefRangeEnd = 1653143, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _OnUpdate_b__7_0(
        TrackComponentChangesSystem.Change x,
        TrackComponentChangesSystem.Change y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) x));
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) y));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrackComponentChangesSystem.__c.NativeMethodInfoPtr__OnUpdate_b__7_0_Internal_Int32_Change_Change_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<TrackComponentChangesSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackComponentChangesSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackComponentChangesSystem.__c>.NativeClassPtr);
        TrackComponentChangesSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackComponentChangesSystem.__c>.NativeClassPtr, "<>9");
        TrackComponentChangesSystem.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackComponentChangesSystem.__c>.NativeClassPtr, "<>9__7_0");
        TrackComponentChangesSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackComponentChangesSystem.__c>.NativeClassPtr, 100664069);
        TrackComponentChangesSystem.__c.NativeMethodInfoPtr__OnUpdate_b__7_0_Internal_Int32_Change_Change_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackComponentChangesSystem.__c>.NativeClassPtr, 100664070);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe TrackComponentChangesSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TrackComponentChangesSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (TrackComponentChangesSystem.__c) null : new TrackComponentChangesSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TrackComponentChangesSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<TrackComponentChangesSystem.Change> __9__7_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(TrackComponentChangesSystem.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<TrackComponentChangesSystem.Change>) null : new Il2CppSystem.Comparison<TrackComponentChangesSystem.Change>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(TrackComponentChangesSystem.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
