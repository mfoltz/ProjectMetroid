// Decompiled with JetBrains decompiler
// Type: ProjectM.FadeToBlackComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class FadeToBlackComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ManualFade;
    private static readonly IntPtr NativeFieldInfoPtr_ActiveTimeline;
    private static readonly IntPtr NativeFieldInfoPtr_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_ManualFadeDurationIn;
    private static readonly IntPtr NativeFieldInfoPtr_ManualFadeDurationOut;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049594, XrefRangeEnd = 1049600, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FadeToBlackComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049600, XrefRangeEnd = 1049606, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FadeToBlackComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FadeToBlackComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FadeToBlackComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FadeToBlackComponent()
    {
      Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FadeToBlackComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr);
      FadeToBlackComponent.NativeFieldInfoPtr_ManualFade = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr, nameof (ManualFade));
      FadeToBlackComponent.NativeFieldInfoPtr_ActiveTimeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr, nameof (ActiveTimeline));
      FadeToBlackComponent.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr, nameof (Curve));
      FadeToBlackComponent.NativeFieldInfoPtr_ManualFadeDurationIn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr, nameof (ManualFadeDurationIn));
      FadeToBlackComponent.NativeFieldInfoPtr_ManualFadeDurationOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr, nameof (ManualFadeDurationOut));
      FadeToBlackComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr, 100682363);
      FadeToBlackComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr, 100682364);
      FadeToBlackComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FadeToBlackComponent>.NativeClassPtr, 100682365);
    }

    public FadeToBlackComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool ManualFade
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_ManualFade));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_ManualFade)) = value;
      }
    }

    public unsafe MinMaxValue ActiveTimeline
    {
      get
      {
        return *(MinMaxValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_ActiveTimeline));
      }
      [param: In] set
      {
        *(MinMaxValue*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_ActiveTimeline)) = value;
      }
    }

    public unsafe CurveReference Curve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_Curve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_Curve)) = value;
      }
    }

    public unsafe float ManualFadeDurationIn
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_ManualFadeDurationIn));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_ManualFadeDurationIn)) = value;
      }
    }

    public unsafe float ManualFadeDurationOut
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_ManualFadeDurationOut));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FadeToBlackComponent.NativeFieldInfoPtr_ManualFadeDurationOut)) = value;
      }
    }
  }
}
