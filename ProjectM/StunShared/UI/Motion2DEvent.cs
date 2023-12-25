// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace StunShared.UI
{
  public sealed class Motion2DEvent : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_Data;
    private static readonly System.IntPtr NativeFieldInfoPtr_EventCallback;

    static Motion2DEvent()
    {
      Il2CppClassPointerStore<Motion2DEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DEvent>.NativeClassPtr);
      Motion2DEvent.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DEvent>.NativeClassPtr, nameof (Time));
      Motion2DEvent.NativeFieldInfoPtr_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DEvent>.NativeClassPtr, nameof (Data));
      Motion2DEvent.NativeFieldInfoPtr_EventCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DEvent>.NativeClassPtr, nameof (EventCallback));
    }

    public Motion2DEvent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public Motion2DEvent()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Motion2DEvent>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Motion2DEvent>.NativeClassPtr, data));
    }

    public unsafe float Time
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DEvent.NativeFieldInfoPtr_Time));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DEvent.NativeFieldInfoPtr_Time)) = value;
      }
    }

    public unsafe Il2CppSystem.Object Data
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DEvent.NativeFieldInfoPtr_Data));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DEvent.NativeFieldInfoPtr_Data), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Il2CppSystem.Action<Il2CppSystem.Object> EventCallback
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DEvent.NativeFieldInfoPtr_EventCallback));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<Il2CppSystem.Object>) null : new Il2CppSystem.Action<Il2CppSystem.Object>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DEvent.NativeFieldInfoPtr_EventCallback), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
