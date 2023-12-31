// Decompiled with JetBrains decompiler
// Type: ProjectM.ReplaceDropTableElement
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ReplaceDropTableElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OriginalDropTable;
    private static readonly System.IntPtr NativeFieldInfoPtr_ReplaceWithDropTable;
    [FieldOffset(0)]
    public PrefabGUID OriginalDropTable;
    [FieldOffset(4)]
    public PrefabGUID ReplaceWithDropTable;

    static ReplaceDropTableElement()
    {
      Il2CppClassPointerStore<ReplaceDropTableElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ReplaceDropTableElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReplaceDropTableElement>.NativeClassPtr);
      ReplaceDropTableElement.NativeFieldInfoPtr_OriginalDropTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTableElement>.NativeClassPtr, nameof (OriginalDropTable));
      ReplaceDropTableElement.NativeFieldInfoPtr_ReplaceWithDropTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReplaceDropTableElement>.NativeClassPtr, nameof (ReplaceWithDropTable));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ReplaceDropTableElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
