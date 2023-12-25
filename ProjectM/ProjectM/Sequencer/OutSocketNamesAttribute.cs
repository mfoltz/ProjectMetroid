// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.OutSocketNamesAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class OutSocketNamesAttribute : SocketNamesAttribute
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe OutSocketNamesAttribute([Optional] Il2CppStringArray socketNames)
    {
      if (socketNames == null)
        socketNames = new Il2CppStringArray(0L);
      // ISSUE: explicit constructor call
      this.\u002Ector(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OutSocketNamesAttribute>.NativeClassPtr));
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) socketNames);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OutSocketNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public OutSocketNamesAttribute(params string[] socketNames)
      : this(new Il2CppStringArray(socketNames))
    {
    }

    static OutSocketNamesAttribute()
    {
      Il2CppClassPointerStore<OutSocketNamesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (OutSocketNamesAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OutSocketNamesAttribute>.NativeClassPtr);
      OutSocketNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OutSocketNamesAttribute>.NativeClassPtr, 100687204);
    }

    public OutSocketNamesAttribute(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
