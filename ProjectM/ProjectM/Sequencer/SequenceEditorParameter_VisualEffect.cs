// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SequenceEditorParameter_VisualEffect
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class SequenceEditorParameter_VisualEffect : SequenceEditorNode
  {
    private static readonly IntPtr NativeFieldInfoPtr_VisualEffectParameter;
    private static readonly IntPtr NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    public override unsafe float GetDuration()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SequenceEditorParameter_VisualEffect.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SequenceEditorParameter_VisualEffect()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SequenceEditorParameter_VisualEffect>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SequenceEditorParameter_VisualEffect.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SequenceEditorParameter_VisualEffect()
    {
      Il2CppClassPointerStore<SequenceEditorParameter_VisualEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SequenceEditorParameter_VisualEffect));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SequenceEditorParameter_VisualEffect>.NativeClassPtr);
      SequenceEditorParameter_VisualEffect.NativeFieldInfoPtr_VisualEffectParameter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SequenceEditorParameter_VisualEffect>.NativeClassPtr, nameof (VisualEffectParameter));
      SequenceEditorParameter_VisualEffect.NativeMethodInfoPtr_GetDuration_Public_Virtual_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorParameter_VisualEffect>.NativeClassPtr, 100686484);
      SequenceEditorParameter_VisualEffect.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SequenceEditorParameter_VisualEffect>.NativeClassPtr, 100686485);
    }

    public SequenceEditorParameter_VisualEffect(IntPtr pointer)
      : base(pointer)
    {
    }

    public Sequence_Editor_VisualEffectParameter VisualEffectParameter
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorParameter_VisualEffect.NativeFieldInfoPtr_VisualEffectParameter);
        return new Sequence_Editor_VisualEffectParameter(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SequenceEditorParameter_VisualEffect.NativeFieldInfoPtr_VisualEffectParameter), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Sequence_Editor_VisualEffectParameter>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
