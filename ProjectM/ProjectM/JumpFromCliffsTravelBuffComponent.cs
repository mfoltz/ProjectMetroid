// Decompiled with JetBrains decompiler
// Type: ProjectM.JumpFromCliffsTravelBuffComponent
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
  public class JumpFromCliffsTravelBuffComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Height;
    private static readonly IntPtr NativeFieldInfoPtr_MaxSearchAngle;
    private static readonly IntPtr NativeFieldInfoPtr_LengthPerHeightCurve;
    private static readonly IntPtr NativeFieldInfoPtr_LengthPerSpeedCurve;
    private static readonly IntPtr NativeFieldInfoPtr_TimePerHeightCurve;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011002, XrefRangeEnd = 1011007, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(JumpFromCliffsTravelBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011007, XrefRangeEnd = 1011017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), JumpFromCliffsTravelBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1011017, XrefRangeEnd = 1011018, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe JumpFromCliffsTravelBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(JumpFromCliffsTravelBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static JumpFromCliffsTravelBuffComponent()
    {
      Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (JumpFromCliffsTravelBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr);
      JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr, nameof (Height));
      JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_MaxSearchAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr, nameof (MaxSearchAngle));
      JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_LengthPerHeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr, nameof (LengthPerHeightCurve));
      JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_LengthPerSpeedCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr, nameof (LengthPerSpeedCurve));
      JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_TimePerHeightCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr, nameof (TimePerHeightCurve));
      JumpFromCliffsTravelBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr, 100678649);
      JumpFromCliffsTravelBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr, 100678650);
      JumpFromCliffsTravelBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JumpFromCliffsTravelBuffComponent>.NativeClassPtr, 100678651);
    }

    public JumpFromCliffsTravelBuffComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Height
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_Height));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_Height)) = value;
      }
    }

    public unsafe float MaxSearchAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_MaxSearchAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_MaxSearchAngle)) = value;
      }
    }

    public unsafe CurveData LengthPerHeightCurve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_LengthPerHeightCurve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_LengthPerHeightCurve)) = value;
      }
    }

    public unsafe CurveData LengthPerSpeedCurve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_LengthPerSpeedCurve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_LengthPerSpeedCurve)) = value;
      }
    }

    public unsafe CurveData TimePerHeightCurve
    {
      get
      {
        return *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_TimePerHeightCurve));
      }
      [param: In] set
      {
        *(CurveData*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(JumpFromCliffsTravelBuffComponent.NativeFieldInfoPtr_TimePerHeightCurve)) = value;
      }
    }
  }
}
