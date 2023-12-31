// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleMemberNames
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleMemberNames
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public FixedString64 Name;

    static CastleMemberNames()
    {
      Il2CppClassPointerStore<CastleMemberNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (CastleMemberNames));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleMemberNames>.NativeClassPtr);
      CastleMemberNames.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleMemberNames>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleMemberNames>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
