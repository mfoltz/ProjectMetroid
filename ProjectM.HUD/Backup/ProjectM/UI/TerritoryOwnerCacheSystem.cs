// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.TerritoryOwnerCacheSystem
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.UI
{
  public class TerritoryOwnerCacheSystem : SystemBase
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CACHE_MAX_AGE;
    private static readonly System.IntPtr NativeFieldInfoPtr__Query;
    private static readonly System.IntPtr NativeFieldInfoPtr__TerritoryOwnerCache;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEntry_Public_Void_Int32_FixedString64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetOwnerName_Public_FixedString64_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetEntry_Private_TerritoryOwnerData_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SendRequest_Private_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273869, XrefRangeEnd = 1273885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateEntry(int territoryIndex, FixedString64 newName)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &territoryIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newName;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritoryOwnerCacheSystem.NativeMethodInfoPtr_UpdateEntry_Public_Void_Int32_FixedString64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1273886, RefRangeEnd = 1273887, XrefRangeStart = 1273885, XrefRangeEnd = 1273886, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FixedString64 GetOwnerName(Entity territoryEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &territoryEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerritoryOwnerCacheSystem.NativeMethodInfoPtr_GetOwnerName_Public_FixedString64_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(FixedString64*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1273914, RefRangeEnd = 1273915, XrefRangeStart = 1273887, XrefRangeEnd = 1273914, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerritoryOwnerCacheSystem.TerritoryOwnerData GetEntry(Entity territoryEntity)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &territoryEntity;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerritoryOwnerCacheSystem.NativeMethodInfoPtr_GetEntry_Private_TerritoryOwnerData_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TerritoryOwnerCacheSystem.TerritoryOwnerData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1273924, RefRangeEnd = 1273925, XrefRangeStart = 1273915, XrefRangeEnd = 1273924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SendRequest(int territoryIndex)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &territoryIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritoryOwnerCacheSystem.NativeMethodInfoPtr_SendRequest_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273925, XrefRangeEnd = 1273937, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerritoryOwnerCacheSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273937, XrefRangeEnd = 1273968, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerritoryOwnerCacheSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1273968, XrefRangeEnd = 1273976, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TerritoryOwnerCacheSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TerritoryOwnerCacheSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TerritoryOwnerCacheSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TerritoryOwnerCacheSystem()
    {
      Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (TerritoryOwnerCacheSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr);
      TerritoryOwnerCacheSystem.NativeFieldInfoPtr_CACHE_MAX_AGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, nameof (CACHE_MAX_AGE));
      TerritoryOwnerCacheSystem.NativeFieldInfoPtr__Query = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, nameof (_Query));
      TerritoryOwnerCacheSystem.NativeFieldInfoPtr__TerritoryOwnerCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, nameof (_TerritoryOwnerCache));
      TerritoryOwnerCacheSystem.NativeMethodInfoPtr_UpdateEntry_Public_Void_Int32_FixedString64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, 100668294);
      TerritoryOwnerCacheSystem.NativeMethodInfoPtr_GetOwnerName_Public_FixedString64_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, 100668295);
      TerritoryOwnerCacheSystem.NativeMethodInfoPtr_GetEntry_Private_TerritoryOwnerData_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, 100668296);
      TerritoryOwnerCacheSystem.NativeMethodInfoPtr_SendRequest_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, 100668297);
      TerritoryOwnerCacheSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, 100668298);
      TerritoryOwnerCacheSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, 100668299);
      TerritoryOwnerCacheSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, 100668300);
      TerritoryOwnerCacheSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, 100668301);
    }

    public TerritoryOwnerCacheSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float CACHE_MAX_AGE
    {
      get
      {
        float cacheMaxAge;
        IL2CPP.il2cpp_field_static_get_value(TerritoryOwnerCacheSystem.NativeFieldInfoPtr_CACHE_MAX_AGE, (void*) &cacheMaxAge);
        return cacheMaxAge;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TerritoryOwnerCacheSystem.NativeFieldInfoPtr_CACHE_MAX_AGE, (void*) &value);
      }
    }

    public unsafe EntityQuery _Query
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryOwnerCacheSystem.NativeFieldInfoPtr__Query));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryOwnerCacheSystem.NativeFieldInfoPtr__Query)) = value;
      }
    }

    public unsafe Dictionary<int, TerritoryOwnerCacheSystem.TerritoryOwnerData> _TerritoryOwnerCache
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TerritoryOwnerCacheSystem.NativeFieldInfoPtr__TerritoryOwnerCache));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, TerritoryOwnerCacheSystem.TerritoryOwnerData>) null : new Dictionary<int, TerritoryOwnerCacheSystem.TerritoryOwnerData>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TerritoryOwnerCacheSystem.NativeFieldInfoPtr__TerritoryOwnerCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TerritoryOwnerData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_InFlight;
      private static readonly System.IntPtr NativeFieldInfoPtr_RequestTime;
      private static readonly System.IntPtr NativeFieldInfoPtr_CharacterName;
      private static readonly System.IntPtr NativeMethodInfoPtr_CreateNew_Public_Static_TerritoryOwnerData_0;
      [FieldOffset(0)]
      public bool InFlight;
      [FieldOffset(4)]
      public float RequestTime;
      [FieldOffset(8)]
      public FixedString64 CharacterName;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 1273868, RefRangeEnd = 1273869, XrefRangeStart = 1273864, XrefRangeEnd = 1273868, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public static unsafe TerritoryOwnerCacheSystem.TerritoryOwnerData CreateNew()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TerritoryOwnerCacheSystem.TerritoryOwnerData.NativeMethodInfoPtr_CreateNew_Public_Static_TerritoryOwnerData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TerritoryOwnerCacheSystem.TerritoryOwnerData*) IL2CPP.il2cpp_object_unbox(num);
      }

      static TerritoryOwnerData()
      {
        Il2CppClassPointerStore<TerritoryOwnerCacheSystem.TerritoryOwnerData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TerritoryOwnerCacheSystem>.NativeClassPtr, nameof (TerritoryOwnerData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TerritoryOwnerCacheSystem.TerritoryOwnerData>.NativeClassPtr);
        TerritoryOwnerCacheSystem.TerritoryOwnerData.NativeFieldInfoPtr_InFlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryOwnerCacheSystem.TerritoryOwnerData>.NativeClassPtr, nameof (InFlight));
        TerritoryOwnerCacheSystem.TerritoryOwnerData.NativeFieldInfoPtr_RequestTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryOwnerCacheSystem.TerritoryOwnerData>.NativeClassPtr, nameof (RequestTime));
        TerritoryOwnerCacheSystem.TerritoryOwnerData.NativeFieldInfoPtr_CharacterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TerritoryOwnerCacheSystem.TerritoryOwnerData>.NativeClassPtr, nameof (CharacterName));
        TerritoryOwnerCacheSystem.TerritoryOwnerData.NativeMethodInfoPtr_CreateNew_Public_Static_TerritoryOwnerData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TerritoryOwnerCacheSystem.TerritoryOwnerData>.NativeClassPtr, 100668302);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TerritoryOwnerCacheSystem.TerritoryOwnerData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
