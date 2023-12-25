// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ExcludeFromMenuAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM.Sequencer
{
  public class ExcludeFromMenuAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ExcludeFromMenuAttribute()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExcludeFromMenuAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ExcludeFromMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ExcludeFromMenuAttribute()
    {
      Il2CppClassPointerStore<ExcludeFromMenuAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ExcludeFromMenuAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExcludeFromMenuAttribute>.NativeClassPtr);
      ExcludeFromMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExcludeFromMenuAttribute>.NativeClassPtr, 100685878);
    }

    public ExcludeFromMenuAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
