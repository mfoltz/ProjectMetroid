// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.InteractMenuAttribute
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM.UI
{
  public class InteractMenuAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InteractMenuAttribute()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractMenuAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InteractMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InteractMenuAttribute()
    {
      Il2CppClassPointerStore<InteractMenuAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.UI", nameof (InteractMenuAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractMenuAttribute>.NativeClassPtr);
      InteractMenuAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractMenuAttribute>.NativeClassPtr, 100670154);
    }

    public InteractMenuAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
