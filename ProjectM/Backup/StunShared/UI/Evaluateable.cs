// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Evaluateable
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  public class Evaluateable : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr__EvaluateDuration_k__BackingField;
    private static readonly IntPtr NativeMethodInfoPtr_EvaluateTime_Public_Abstract_Virtual_New_State_Single_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_EvaluateDuration_Public_Virtual_New_get_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr_set_EvaluateDuration_Public_Virtual_New_set_Void_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(0)]
    public virtual unsafe Evaluateable.State EvaluateTime(float elapsed, bool invokeEventCallbacks = true)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &elapsed;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &invokeEventCallbacks;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Evaluateable.NativeMethodInfoPtr_EvaluateTime_Public_Abstract_Virtual_New_State_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Evaluateable.State*) IL2CPP.il2cpp_object_unbox(num);
    }

    public virtual unsafe float EvaluateDuration
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Evaluateable.NativeMethodInfoPtr_get_EvaluateDuration_Public_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 318413, RefRangeEnd = 318415, XrefRangeStart = 318413, XrefRangeEnd = 318415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = stackalloc IntPtr[1];
        numPtr[0] = (IntPtr) &value;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), Evaluateable.NativeMethodInfoPtr_set_EvaluateDuration_Public_Virtual_New_set_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Evaluateable()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Evaluateable>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Evaluateable.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Evaluateable()
    {
      Il2CppClassPointerStore<Evaluateable>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Evaluateable));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Evaluateable>.NativeClassPtr);
      Evaluateable.NativeFieldInfoPtr__EvaluateDuration_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Evaluateable>.NativeClassPtr, "<EvaluateDuration>k__BackingField");
      Evaluateable.NativeMethodInfoPtr_EvaluateTime_Public_Abstract_Virtual_New_State_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evaluateable>.NativeClassPtr, 100663757);
      Evaluateable.NativeMethodInfoPtr_get_EvaluateDuration_Public_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evaluateable>.NativeClassPtr, 100663758);
      Evaluateable.NativeMethodInfoPtr_set_EvaluateDuration_Public_Virtual_New_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evaluateable>.NativeClassPtr, 100663759);
      Evaluateable.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Evaluateable>.NativeClassPtr, 100663760);
    }

    public Evaluateable(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float _EvaluateDuration_k__BackingField
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Evaluateable.NativeFieldInfoPtr__EvaluateDuration_k__BackingField));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Evaluateable.NativeFieldInfoPtr__EvaluateDuration_k__BackingField)) = value;
      }
    }

    public enum State
    {
      None,
      Animating,
      Finished,
    }
  }
}
