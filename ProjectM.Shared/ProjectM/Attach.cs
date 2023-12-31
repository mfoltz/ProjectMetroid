// Decompiled with JetBrains decompiler
// Type: ProjectM.Attach
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct Attach
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_0;
    [FieldOffset(0)]
    public Entity Parent;

    [CallerCount(34)]
    [CachedScanResults(RefRangeStart = 723626, RefRangeEnd = 723660, XrefRangeStart = 723624, XrefRangeEnd = 723626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Attach(Entity parent)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &parent;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Attach.NativeMethodInfoPtr__ctor_Public_Void_Entity_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Attach()
    {
      Il2CppClassPointerStore<Attach>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (Attach));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Attach>.NativeClassPtr);
      Attach.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Attach>.NativeClassPtr, nameof (Parent));
      Attach.NativeMethodInfoPtr__ctor_Public_Void_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Attach>.NativeClassPtr, 100663981);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Attach>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
