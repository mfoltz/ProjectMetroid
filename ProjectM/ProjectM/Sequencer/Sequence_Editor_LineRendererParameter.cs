// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.Sequence_Editor_LineRendererParameter
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  [Serializable]
  public sealed class Sequence_Editor_LineRendererParameter : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LineRenderer;
    private static readonly System.IntPtr NativeFieldInfoPtr_Positions;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidatePositions_Public_Void_HybridLineRendererComponent_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1093653, XrefRangeEnd = 1093670, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ValidatePositions(HybridLineRendererComponent lineRenderer)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lineRenderer);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Sequence_Editor_LineRendererParameter.NativeMethodInfoPtr_ValidatePositions_Public_Void_HybridLineRendererComponent_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Sequence_Editor_LineRendererParameter()
    {
      Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (Sequence_Editor_LineRendererParameter));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter>.NativeClassPtr);
      Sequence_Editor_LineRendererParameter.NativeFieldInfoPtr_LineRenderer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter>.NativeClassPtr, nameof (LineRenderer));
      Sequence_Editor_LineRendererParameter.NativeFieldInfoPtr_Positions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter>.NativeClassPtr, nameof (Positions));
      Sequence_Editor_LineRendererParameter.NativeMethodInfoPtr_ValidatePositions_Public_Void_HybridLineRendererComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter>.NativeClassPtr, 100686483);
    }

    public Sequence_Editor_LineRendererParameter(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Sequence_Editor_LineRendererParameter()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter>.NativeClassPtr, data));
    }

    public unsafe LineRenderer LineRenderer
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_LineRendererParameter.NativeFieldInfoPtr_LineRenderer));
        return pointer == System.IntPtr.Zero ? (LineRenderer) null : new LineRenderer(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_LineRendererParameter.NativeFieldInfoPtr_LineRenderer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<Sequence_Editor_LineRendererParameter.DummyPositionValue> Positions
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_LineRendererParameter.NativeFieldInfoPtr_Positions));
        return pointer == System.IntPtr.Zero ? (List<Sequence_Editor_LineRendererParameter.DummyPositionValue>) null : new List<Sequence_Editor_LineRendererParameter.DummyPositionValue>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_LineRendererParameter.NativeFieldInfoPtr_Positions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public sealed class DummyPositionValue : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Value;

      static DummyPositionValue()
      {
        Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter.DummyPositionValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter>.NativeClassPtr, nameof (DummyPositionValue));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter.DummyPositionValue>.NativeClassPtr);
        Sequence_Editor_LineRendererParameter.DummyPositionValue.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter.DummyPositionValue>.NativeClassPtr, nameof (Value));
      }

      public DummyPositionValue(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public DummyPositionValue()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter.DummyPositionValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sequence_Editor_LineRendererParameter.DummyPositionValue>.NativeClassPtr, data));
      }

      public BlackboardParameterValue Value
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_LineRendererParameter.DummyPositionValue.NativeFieldInfoPtr_Value);
          return new BlackboardParameterValue(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Sequence_Editor_LineRendererParameter.DummyPositionValue.NativeFieldInfoPtr_Value), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<BlackboardParameterValue>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }
    }
  }
}
