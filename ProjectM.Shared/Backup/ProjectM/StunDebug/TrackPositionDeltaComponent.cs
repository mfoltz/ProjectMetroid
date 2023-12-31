// Decompiled with JetBrains decompiler
// Type: ProjectM.StunDebug.TrackPositionDeltaComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.StunDebug
{
  public class TrackPositionDeltaComponent : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__LastPos;
    private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770777, XrefRangeEnd = 770779, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Start()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrackPositionDeltaComponent.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 770779, XrefRangeEnd = 770793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrackPositionDeltaComponent.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrackPositionDeltaComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackPositionDeltaComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrackPositionDeltaComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TrackPositionDeltaComponent()
    {
      Il2CppClassPointerStore<TrackPositionDeltaComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.StunDebug", nameof (TrackPositionDeltaComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackPositionDeltaComponent>.NativeClassPtr);
      TrackPositionDeltaComponent.NativeFieldInfoPtr__LastPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackPositionDeltaComponent>.NativeClassPtr, nameof (_LastPos));
      TrackPositionDeltaComponent.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackPositionDeltaComponent>.NativeClassPtr, 100668267);
      TrackPositionDeltaComponent.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackPositionDeltaComponent>.NativeClassPtr, 100668268);
      TrackPositionDeltaComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackPositionDeltaComponent>.NativeClassPtr, 100668269);
    }

    public TrackPositionDeltaComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Vector3 _LastPos
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackPositionDeltaComponent.NativeFieldInfoPtr__LastPos));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrackPositionDeltaComponent.NativeFieldInfoPtr__LastPos)) = value;
      }
    }
  }
}
