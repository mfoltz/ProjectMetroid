// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DInOut
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  public class Motion2DInOut : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_InMotions;
    private static readonly IntPtr NativeFieldInfoPtr_OutDelay;
    private static readonly IntPtr NativeFieldInfoPtr_OutMotions;
    private static readonly IntPtr NativeFieldInfoPtr__InTime;
    private static readonly IntPtr NativeFieldInfoPtr__OutTime;
    private static readonly IntPtr NativeFieldInfoPtr__Direction;
    private static readonly IntPtr NativeFieldInfoPtr__LastState;
    private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_State_Boolean_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Void_Direction_Single_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(43)]
    [CachedScanResults(RefRangeStart = 922673, RefRangeEnd = 922716, XrefRangeStart = 922646, XrefRangeEnd = 922673, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Evaluateable.State Evaluate(bool show, bool reset = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &show;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &reset;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(Motion2DInOut.NativeMethodInfoPtr_Evaluate_Public_State_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Evaluateable.State*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4)]
    [CachedScanResults(RefRangeStart = 922730, RefRangeEnd = 922734, XrefRangeStart = 922716, XrefRangeEnd = 922730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Evaluate(Motion2DInOut.Direction direction, float t)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &direction;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &t;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DInOut.NativeMethodInfoPtr_Evaluate_Public_Void_Direction_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 922734, XrefRangeEnd = 922735, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DInOut()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DInOut.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Motion2DInOut()
    {
      Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DInOut));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr);
      Motion2DInOut.NativeFieldInfoPtr_InMotions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, nameof (InMotions));
      Motion2DInOut.NativeFieldInfoPtr_OutDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, nameof (OutDelay));
      Motion2DInOut.NativeFieldInfoPtr_OutMotions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, nameof (OutMotions));
      Motion2DInOut.NativeFieldInfoPtr__InTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, nameof (_InTime));
      Motion2DInOut.NativeFieldInfoPtr__OutTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, nameof (_OutTime));
      Motion2DInOut.NativeFieldInfoPtr__Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, nameof (_Direction));
      Motion2DInOut.NativeFieldInfoPtr__LastState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, nameof (_LastState));
      Motion2DInOut.NativeMethodInfoPtr_Evaluate_Public_State_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, 100663817);
      Motion2DInOut.NativeMethodInfoPtr_Evaluate_Public_Void_Direction_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, 100663818);
      Motion2DInOut.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DInOut>.NativeClassPtr, 100663819);
    }

    public Motion2DInOut(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<Motion2DBinding> InMotions
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr_InMotions));
        return pointer == IntPtr.Zero ? (List<Motion2DBinding>) null : new List<Motion2DBinding>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr_InMotions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float OutDelay
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr_OutDelay));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr_OutDelay)) = value;
      }
    }

    public unsafe List<Motion2DBinding> OutMotions
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr_OutMotions));
        return pointer == IntPtr.Zero ? (List<Motion2DBinding>) null : new List<Motion2DBinding>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr_OutMotions), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float _InTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr__InTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr__InTime)) = value;
      }
    }

    public unsafe float _OutTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr__OutTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr__OutTime)) = value;
      }
    }

    public unsafe Motion2DInOut.Direction _Direction
    {
      get
      {
        return *(Motion2DInOut.Direction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr__Direction));
      }
      [param: In] set
      {
        *(Motion2DInOut.Direction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr__Direction)) = value;
      }
    }

    public unsafe Evaluateable.State _LastState
    {
      get
      {
        return *(Evaluateable.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr__LastState));
      }
      [param: In] set
      {
        *(Evaluateable.State*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DInOut.NativeFieldInfoPtr__LastState)) = value;
      }
    }

    public enum Direction
    {
      Out,
      In,
    }
  }
}
