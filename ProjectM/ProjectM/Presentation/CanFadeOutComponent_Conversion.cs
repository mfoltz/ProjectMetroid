// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.CanFadeOutComponent_Conversion
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public class CanFadeOutComponent_Conversion : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FillAndSetupFadersRecursively_Public_Static_Void_GameObjectConversionSystem_GameObject_List_1_Entity_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112333, XrefRangeEnd = 1112376, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CanFadeOutComponent_Conversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1112447, RefRangeEnd = 1112450, XrefRangeStart = 1112376, XrefRangeEnd = 1112447, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FillAndSetupFadersRecursively(
      GameObjectConversionSystem converisonSystem,
      GameObject gameObject,
      List<Entity> faders)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) converisonSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameObject);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) faders);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CanFadeOutComponent_Conversion.NativeMethodInfoPtr_FillAndSetupFadersRecursively_Public_Static_Void_GameObjectConversionSystem_GameObject_List_1_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CanFadeOutComponent_Conversion()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanFadeOutComponent_Conversion>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CanFadeOutComponent_Conversion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CanFadeOutComponent_Conversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CanFadeOutComponent_Conversion()
    {
      Il2CppClassPointerStore<CanFadeOutComponent_Conversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (CanFadeOutComponent_Conversion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanFadeOutComponent_Conversion>.NativeClassPtr);
      CanFadeOutComponent_Conversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFadeOutComponent_Conversion>.NativeClassPtr, 100688060);
      CanFadeOutComponent_Conversion.NativeMethodInfoPtr_FillAndSetupFadersRecursively_Public_Static_Void_GameObjectConversionSystem_GameObject_List_1_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFadeOutComponent_Conversion>.NativeClassPtr, 100688061);
      CanFadeOutComponent_Conversion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFadeOutComponent_Conversion>.NativeClassPtr, 100688062);
      CanFadeOutComponent_Conversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFadeOutComponent_Conversion>.NativeClassPtr, 100688063);
    }

    public CanFadeOutComponent_Conversion(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("ProjectM.Presentation.CanFadeOutComponent_Conversion/<>c__DisplayClass0_0")]
    public sealed class __c__DisplayClass0_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_faders;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_CanFadeOutComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_CanFadeOutComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_HeightLevelCullingAuthoring_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass0_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanFadeOutComponent_Conversion.__c__DisplayClass0_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112234, XrefRangeEnd = 1112265, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(CanFadeOutComponent fadeoutComponent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fadeoutComponent);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_CanFadeOutComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112265, XrefRangeEnd = 1112272, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(CanFadeOutComponent fadeoutComponent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) fadeoutComponent);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_CanFadeOutComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112272, XrefRangeEnd = 1112333, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(HeightLevelCullingAuthoring heightLevelCulling)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) heightLevelCulling);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_HeightLevelCullingAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass0_0()
      {
        Il2CppClassPointerStore<CanFadeOutComponent_Conversion.__c__DisplayClass0_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CanFadeOutComponent_Conversion>.NativeClassPtr, "<>c__DisplayClass0_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanFadeOutComponent_Conversion.__c__DisplayClass0_0>.NativeClassPtr);
        CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFadeOutComponent_Conversion.__c__DisplayClass0_0>.NativeClassPtr, "<>4__this");
        CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeFieldInfoPtr_faders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanFadeOutComponent_Conversion.__c__DisplayClass0_0>.NativeClassPtr, nameof (faders));
        CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFadeOutComponent_Conversion.__c__DisplayClass0_0>.NativeClassPtr, 100688064);
        CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_CanFadeOutComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFadeOutComponent_Conversion.__c__DisplayClass0_0>.NativeClassPtr, 100688065);
        CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_CanFadeOutComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFadeOutComponent_Conversion.__c__DisplayClass0_0>.NativeClassPtr, 100688066);
        CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_HeightLevelCullingAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanFadeOutComponent_Conversion.__c__DisplayClass0_0>.NativeClassPtr, 100688067);
      }

      public __c__DisplayClass0_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe CanFadeOutComponent_Conversion __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (CanFadeOutComponent_Conversion) null : new CanFadeOutComponent_Conversion(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<Entity> faders
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeFieldInfoPtr_faders));
          return pointer == System.IntPtr.Zero ? (List<Entity>) null : new List<Entity>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CanFadeOutComponent_Conversion.__c__DisplayClass0_0.NativeFieldInfoPtr_faders), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
