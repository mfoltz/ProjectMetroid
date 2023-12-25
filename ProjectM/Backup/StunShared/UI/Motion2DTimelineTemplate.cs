// Decompiled with JetBrains decompiler
// Type: StunShared.UI.Motion2DTimelineTemplate
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace StunShared.UI
{
  public class Motion2DTimelineTemplate : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_Timeline;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 247159, RefRangeEnd = 247170, XrefRangeStart = 247159, XrefRangeEnd = 247170, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Motion2DTimelineTemplate()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Motion2DTimelineTemplate>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Motion2DTimelineTemplate.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Motion2DTimelineTemplate()
    {
      Il2CppClassPointerStore<Motion2DTimelineTemplate>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "StunShared.UI", nameof (Motion2DTimelineTemplate));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Motion2DTimelineTemplate>.NativeClassPtr);
      Motion2DTimelineTemplate.NativeFieldInfoPtr_Timeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Motion2DTimelineTemplate>.NativeClassPtr, nameof (Timeline));
      Motion2DTimelineTemplate.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Motion2DTimelineTemplate>.NativeClassPtr, 100663857);
    }

    public Motion2DTimelineTemplate(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Motion2DTimeline Timeline
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineTemplate.NativeFieldInfoPtr_Timeline));
        return pointer == IntPtr.Zero ? (Motion2DTimeline) null : new Motion2DTimeline(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Motion2DTimelineTemplate.NativeFieldInfoPtr_Timeline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
