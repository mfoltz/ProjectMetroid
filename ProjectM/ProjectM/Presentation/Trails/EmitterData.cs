// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.EmitterData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  public sealed class EmitterData : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StartColor;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartSize;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SizeOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetXOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetYOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_OffsetZOverLifetime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Material;
    private static readonly System.IntPtr NativeFieldInfoPtr_MeshType;
    private static readonly System.IntPtr NativeFieldInfoPtr_UVMode;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilesU;
    private static readonly System.IntPtr NativeFieldInfoPtr_TilesV;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdateParticles;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdateVertices;
    private static readonly System.IntPtr NativeFieldInfoPtr_Local;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    private static readonly System.IntPtr NativeFieldInfoPtr_Rotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_CyclesPerSecond;
    private static readonly System.IntPtr NativeFieldInfoPtr_Layer;
    private static readonly System.IntPtr NativeFieldInfoPtr_TimeStopped;
    private static readonly System.IntPtr NativeFieldInfoPtr_FadeOutTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_Lifetime;

    static EmitterData()
    {
      Il2CppClassPointerStore<EmitterData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (EmitterData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmitterData>.NativeClassPtr);
      EmitterData.NativeFieldInfoPtr_StartColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (StartColor));
      EmitterData.NativeFieldInfoPtr_StartSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (StartSize));
      EmitterData.NativeFieldInfoPtr_ColorOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (ColorOverLifetime));
      EmitterData.NativeFieldInfoPtr_SizeOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (SizeOverLifetime));
      EmitterData.NativeFieldInfoPtr_OffsetXOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (OffsetXOverLifetime));
      EmitterData.NativeFieldInfoPtr_OffsetYOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (OffsetYOverLifetime));
      EmitterData.NativeFieldInfoPtr_OffsetZOverLifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (OffsetZOverLifetime));
      EmitterData.NativeFieldInfoPtr_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (Material));
      EmitterData.NativeFieldInfoPtr_MeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (MeshType));
      EmitterData.NativeFieldInfoPtr_UVMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (UVMode));
      EmitterData.NativeFieldInfoPtr_TilesU = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (TilesU));
      EmitterData.NativeFieldInfoPtr_TilesV = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (TilesV));
      EmitterData.NativeFieldInfoPtr_UpdateParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (UpdateParticles));
      EmitterData.NativeFieldInfoPtr_UpdateVertices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (UpdateVertices));
      EmitterData.NativeFieldInfoPtr_Local = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (Local));
      EmitterData.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (Position));
      EmitterData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (Rotation));
      EmitterData.NativeFieldInfoPtr_CyclesPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (CyclesPerSecond));
      EmitterData.NativeFieldInfoPtr_Layer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (Layer));
      EmitterData.NativeFieldInfoPtr_TimeStopped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (TimeStopped));
      EmitterData.NativeFieldInfoPtr_FadeOutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (FadeOutTime));
      EmitterData.NativeFieldInfoPtr_Lifetime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, nameof (Lifetime));
    }

    public EmitterData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public EmitterData()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, data));
    }

    public unsafe Color32 StartColor
    {
      get
      {
        return *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_StartColor));
      }
      [param: In] set
      {
        *(Color32*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_StartColor)) = value;
      }
    }

    public unsafe float StartSize
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_StartSize));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_StartSize)) = value;
      }
    }

    public unsafe Gradient ColorOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_ColorOverLifetime));
        return pointer == System.IntPtr.Zero ? (Gradient) null : new Gradient(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_ColorOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve SizeOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_SizeOverLifetime));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_SizeOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve OffsetXOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_OffsetXOverLifetime));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_OffsetXOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve OffsetYOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_OffsetYOverLifetime));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_OffsetYOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe AnimationCurve OffsetZOverLifetime
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_OffsetZOverLifetime));
        return pointer == System.IntPtr.Zero ? (AnimationCurve) null : new AnimationCurve(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_OffsetZOverLifetime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Material Material
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Material));
        return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MeshType MeshType
    {
      get
      {
        return *(MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_MeshType));
      }
      [param: In] set
      {
        *(MeshType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_MeshType)) = value;
      }
    }

    public unsafe UVMode UVMode
    {
      get
      {
        return *(UVMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_UVMode));
      }
      [param: In] set
      {
        *(UVMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_UVMode)) = value;
      }
    }

    public unsafe short TilesU
    {
      get
      {
        return *(short*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_TilesU));
      }
      [param: In] set
      {
        *(short*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_TilesU)) = value;
      }
    }

    public unsafe short TilesV
    {
      get
      {
        return *(short*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_TilesV));
      }
      [param: In] set
      {
        *(short*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_TilesV)) = value;
      }
    }

    public unsafe bool UpdateParticles
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_UpdateParticles));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_UpdateParticles)) = value;
      }
    }

    public unsafe bool UpdateVertices
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_UpdateVertices));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_UpdateVertices)) = value;
      }
    }

    public unsafe bool Local
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Local));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Local)) = value;
      }
    }

    public unsafe Vector3 Position
    {
      get
      {
        return *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Position));
      }
      [param: In] set
      {
        *(Vector3*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Position)) = value;
      }
    }

    public unsafe Quaternion Rotation
    {
      get
      {
        return *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Rotation));
      }
      [param: In] set
      {
        *(Quaternion*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Rotation)) = value;
      }
    }

    public unsafe float CyclesPerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_CyclesPerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_CyclesPerSecond)) = value;
      }
    }

    public unsafe int Layer
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Layer));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Layer)) = value;
      }
    }

    public unsafe Nullable_Unboxed<float> TimeStopped
    {
      get
      {
        return *(Nullable_Unboxed<float>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_TimeStopped));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_TimeStopped), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<float>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    public unsafe float FadeOutTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_FadeOutTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_FadeOutTime)) = value;
      }
    }

    public unsafe float Lifetime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Lifetime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EmitterData.NativeFieldInfoPtr_Lifetime)) = value;
      }
    }
  }
}
