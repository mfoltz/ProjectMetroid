// Decompiled with JetBrains decompiler
// Type: Tests.UnitTestingObjectProxy
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace Tests
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitTestingObjectProxy
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ObjectTag;
    [FieldOffset(0)]
    public FixedString128 ObjectTag;

    static UnitTestingObjectProxy()
    {
      Il2CppClassPointerStore<UnitTestingObjectProxy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Tests", nameof (UnitTestingObjectProxy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitTestingObjectProxy>.NativeClassPtr);
      UnitTestingObjectProxy.NativeFieldInfoPtr_ObjectTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitTestingObjectProxy>.NativeClassPtr, nameof (ObjectTag));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitTestingObjectProxy>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
